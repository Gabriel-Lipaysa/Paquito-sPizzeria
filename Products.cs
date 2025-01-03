using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paquito_sPizzeria
{   
    public partial class Products : Form
    {
        private MainForm mainForm;
        private string connectionString = "Server=localhost;Uid=root;Database=pizza_pizza;";
        public Products(MainForm main)
        {
            InitializeComponent();
            mainForm = main;
        }
        public void display()
        {
            string query = "select id, name, price, quantity, description from products";
            var conn = new MySqlConnection(connectionString);
            using (var cmd = new MySqlCommand(query, conn))
            {
                conn.Open();
                try
                {
                    var adapter = new MySqlDataAdapter(cmd);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    productGridView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Products_Load(object sender, EventArgs e)
        {
            display();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string query = "Delete from products where id = @id";

            if (productGridView.SelectedCells.Count > 0)
            {
                var selectedCell = productGridView.CurrentCell;
                var rowIndex = selectedCell.RowIndex;
                var selectedRow = productGridView.Rows[rowIndex];
                var cellValue = selectedRow.Cells["id"].Value;
                int id = int.Parse(cellValue.ToString());

                using (var conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        var cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("id", id);
                        cmd.ExecuteNonQuery();
                        display();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = "select id, name, price, quantity, description from products where id like @search or name like @search or  price like @search or quantity like @search or description like @search ";
            string search = searchTxt.Text.Trim();
            if (search != null)
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    try
                    {
                        var adapter = new MySqlDataAdapter(query, conn);
                        adapter.SelectCommand.Parameters.AddWithValue("search", $"%{search}%");
                        var dt = new DataTable();
                        adapter.Fill(dt);
                        productGridView.DataSource = dt;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            mainForm.LoadForm(new EditProducts());

        }
    }
}

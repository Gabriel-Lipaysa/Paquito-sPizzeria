using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Paquito_sPizzeria
{
    public partial class Users : Form
    {
        private string connectionString = "Server=localhost;Uid=root;Database=pizza_pizza";
        public Users()
        {
            InitializeComponent();
        }

        public void display()
        {
            string query = "select id, name, email from user";
            var conn = new MySqlConnection(connectionString);
            using (var cmd = new MySqlCommand(query, conn))
            {
                conn.Open();
                try
                {
                    var adapter = new MySqlDataAdapter(cmd);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    UsersGridView.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Users_Load(object sender, EventArgs e)
        {
           display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "Delete from user where id = @id";
            
            if (UsersGridView.SelectedCells.Count > 0)
            {
                var selectedCell = UsersGridView.CurrentCell;
                var rowIndex= selectedCell.RowIndex;
                var selectedRow = UsersGridView.Rows[rowIndex];
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
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}

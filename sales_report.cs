using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace Paquito_sPizzeria
{
    public partial class sales_report : Form
    {
        private string connectionString = "Server=localhost;Uid=root;Database=pizza_pizza;";
        public sales_report()
        {
            InitializeComponent();
        }

        public void display()
        {
            String query = @"
                select 
                    products.name, sales.qty, sales.price, sales.date,  GROUP_CONCAT(customization.cusName SEPARATOR '\n') AS customization_names, size.sizename
                from 
                    sales 
                JOIN 
                    products on sales.product_id = products.id
                JOIN
                    customization ON FIND_IN_SET(customization.cusID, sales.cusIDs) > 0
                JOIN
                    size on sales.sizeID = size.sizeID
                GROUP BY
                    products.name, sales.qty, sales.price, sales.date, size.sizename
            ";


            var dt = new DataTable();
            using (var conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (var adapter = new MySqlDataAdapter(query, conn))
                    {
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void sales_report_Load(object sender, EventArgs e)
        {
            
            display();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(searchTxt.Text != null)
            {

                String query = @"
                select 
                    products.name, sales.qty, sales.price, sales.date,  GROUP_CONCAT(customization.cusName SEPARATOR '\n') AS customization_names, size.sizename
                from 
                    sales 
                JOIN 
                    products on sales.product_id = products.id
                JOIN
                    customization ON FIND_IN_SET(customization.cusID, sales.cusIDs) > 0
                JOIN
                    size on sales.sizeID = size.sizeID
                WHERE 
                    products.name like @search
                GROUP BY
                    products.name, sales.qty, sales.price, sales.date, size.sizename
                ";


                var dt = new DataTable();
                using (var conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        using (var cmd = new MySqlCommand(query, conn))
                        {
                            var adapter = new MySqlDataAdapter(cmd);
                            adapter.SelectCommand.Parameters.AddWithValue("search", "%" + searchTxt.Text + "%");
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            
            }
            else
            {
                display();
            }
        }

        private void filterDate_ValueChanged(object sender, EventArgs e)
        {
            int selectedMonth = filterDate.Value.Month;
            int selectedYear = filterDate.Value.Year;
            String query = @"
                select 
                    products.name, sales.qty, sales.price, sales.date,  GROUP_CONCAT(customization.cusName SEPARATOR '\n') AS customization_names, size.sizename
                from 
                    sales 
                JOIN 
                    products on sales.product_id = products.id
                JOIN
                    customization ON FIND_IN_SET(customization.cusID, sales.cusIDs) > 0
                JOIN
                    size on sales.sizeID = size.sizeID
                WHERE 
                    YEAR(sales.date) = @year AND MONTH(sales.date) = @month
                GROUP BY
                    products.name, sales.qty, sales.price, sales.date, size.sizename
                ";


            var dt = new DataTable();
            using (var conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        var adapter = new MySqlDataAdapter(cmd);
                        adapter.SelectCommand.Parameters.AddWithValue("year", selectedYear );
                        adapter.SelectCommand.Parameters.AddWithValue("month",  selectedMonth );
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

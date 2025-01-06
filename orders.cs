using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace Paquito_sPizzeria
{
    public partial class Orders : Form
    {
        private string connectionString = "Server=localhost;Uid=root;Database=pizza_pizza;";
        private MainForm mainForm;
        private int cmbIndex;
        public Orders(MainForm mainForm, int? cmbIndex = null)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.cmbIndex = cmbIndex ?? 0;
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            filterCmb.SelectedIndex = cmbIndex;
            LoadOrders();
        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void filterCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders()
        {
            
            String query = @"
                SELECT 
                    orders.id as 'ID', 
                    orders.placed_on as 'Order Placed', 
                    orders.name as 'Customer', 
                    orders.number as 'Phone Number', 
                    orders.address as 'Address', 
                    GROUP_CONCAT(CONCAT(order_items.name, ' (', IFNULL(customization.cusName, 'No Customization'), ')') SEPARATOR '\n') AS Product, 
                    orders.total_price as 'Total', 
                    orders.method as 'Payment Method', 
                    orders.payment_status as 'Status' 
                FROM orders 
                join order_items ON orders.id = order_items.order_id 
                LEFT JOIN customization ON FIND_IN_SET(customization.cusID, order_items.customizations) > 0 
                WHERE 1 = 1
                ";

            if (filterCmb.SelectedIndex == 1)
            {
                query += " AND orders.payment_status = 'pending'";
            }

            if (filterCmb.SelectedIndex == 2)
            {
                query += " AND orders.payment_status = 'completed'";
            }

            if (!string.IsNullOrEmpty(searchTxtBox.Text))
            {
                query += " AND (orders.name LIKE @filter OR orders.address LIKE @filter)";
            }

            query += @"
               GROUP BY 
                    orders.id, 
                    orders.placed_on, 
                    orders.name, 
                    orders.number, 
                    orders.address, 
                    orders.total_price, 
                    orders.method, 
                    orders.payment_status 
                    ORDER BY orders.placed_on DESC";

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                try
                {
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(searchTxtBox.Text))
                        {
                            cmd.Parameters.AddWithValue("@filter", "%" + searchTxtBox.Text + "%");
                        }

                        var adapter = new MySqlDataAdapter(cmd);
                        var dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            int rowsCount = dataGridView1.Rows.Count - 1;
            lblTotal.Text = "Total: " + rowsCount.ToString();
        }

        
    }
    
}

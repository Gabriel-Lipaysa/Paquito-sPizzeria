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
        public Orders()
        {
            InitializeComponent();
            //this.mainForm = mainForm;
        }
        private void display()
        {
            cmbFilter.SelectedIndex = 0;
            String query =
             @"
                SELECT
                    orders.id,
                    placed_on,
                    orders.name,
                    orders.number,
                    orders.address,
                    GROUP_CONCAT(
                        CONCAT(
                            order_items.quantity, 
                            'x ', 
                            order_items.name,
                            ' (',
                            order_items.size,
                            ')',
                            ' Customization: ',  
                            IFNULL(customization_names.cusNames, 'N/A')
                        ) 
                        SEPARATOR '\n'
                    ) AS Product,
                    orders.total_price,
                    orders.method,
                    orders.payment_status
                FROM 
                    orders
                JOIN 
                    order_items ON order_items.order_id = orders.id
                LEFT JOIN 
                    (
                        SELECT 
                            order_items.id AS order_item_id,
                            GROUP_CONCAT(customization.cusName SEPARATOR ', ') AS cusNames
                        FROM 
                            order_items
                        LEFT JOIN 
                            customization ON FIND_IN_SET(customization.cusID, order_items.customizations) > 0
                        GROUP BY 
                            order_items.id
                    ) AS customization_names ON customization_names.order_item_id = order_items.id
                GROUP BY
                    orders.id, orders.placed_on, orders.name, orders.number, orders.address, orders.total_price, orders.method, orders.payment_status

            ";


            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                try
                {
                    using (var cmd = new MySqlCommand(query, conn))
                    {
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
            lblTotal.Text = rowsCount.ToString();
        }

        private void orders_Load(object sender, EventArgs e)
        {
            display();
        }


        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            String query;
            if (cmbFilter.SelectedIndex == 2)
            {

                query =
                @"
                SELECT
                    orders.id,
                    placed_on,
                    orders.name,
                    orders.number,
                    orders.address,
                    GROUP_CONCAT(
                        CONCAT(
                            order_items.quantity, 
                            'x ', 
                            order_items.name,
                            ' (',
                            order_items.size,
                            ')',
                            ' Customization: ',  
                            IFNULL(customization_names.cusNames, 'N/A')
                        ) 
                        SEPARATOR '\n'
                    ) AS Product,
                    orders.total_price,
                    orders.method,
                    orders.payment_status
                FROM 
                    orders
                JOIN 
                    order_items ON order_items.order_id = orders.id
                LEFT JOIN 
                    (
                        SELECT 
                            order_items.id AS order_item_id,
                            GROUP_CONCAT(customization.cusName SEPARATOR ', ') AS cusNames
                        FROM 
                            order_items
                        LEFT JOIN 
                            customization ON FIND_IN_SET(customization.cusID, order_items.customizations) > 0
                        GROUP BY 
                            order_items.id
                    ) AS customization_names ON customization_names.order_item_id = order_items.id
                WHERE 
                    orders.payment_status = 'pending'
                GROUP BY
                    orders.id, orders.placed_on, orders.name, orders.number, orders.address, orders.total_price, orders.method, orders.payment_status

            ";
            }
            else if (cmbFilter.SelectedIndex == 1)
            {
                query =
             @"
                SELECT
                    orders.id,
                    placed_on,
                    orders.name,
                    orders.number,
                    orders.address,
                    GROUP_CONCAT(
                        CONCAT(
                            order_items.quantity, 
                            'x ', 
                            order_items.name,
                            ' (',
                            order_items.size,
                            ')',
                            ' Customization: ',  
                            IFNULL(customization_names.cusNames, 'N/A')
                        ) 
                        SEPARATOR '\n'
                    ) AS Product,
                    orders.total_price,
                    orders.method,
                    orders.payment_status
                FROM 
                    orders
                JOIN 
                    order_items ON order_items.order_id = orders.id
                LEFT JOIN 
                    (
                        SELECT 
                            order_items.id AS order_item_id,
                            GROUP_CONCAT(customization.cusName SEPARATOR ', ') AS cusNames
                        FROM 
                            order_items
                        LEFT JOIN 
                            customization ON FIND_IN_SET(customization.cusID, order_items.customizations) > 0
                        GROUP BY 
                            order_items.id
                    ) AS customization_names ON customization_names.order_item_id = order_items.id
                WHERE 
                    orders.payment_status = 'Completed'
                GROUP BY
                    orders.id, orders.placed_on, orders.name, orders.number, orders.address, orders.total_price, orders.method, orders.payment_status

            ";
            }
            else
            {
                query =
                @"
                    SELECT
                        orders.id,
                        placed_on,
                        orders.name,
                        orders.number,
                        orders.address,
                        GROUP_CONCAT(
                            CONCAT(
                                order_items.quantity, 
                                'x ', 
                                order_items.name,
                                ' (',
                                order_items.size,
                                ')',
                                ' Customization: ',  
                                IFNULL(customization_names.cusNames, 'N/A')
                            ) 
                            SEPARATOR '\n'
                        ) AS Product,
                        orders.total_price,
                        orders.method,
                        orders.payment_status
                    FROM 
                        orders
                    JOIN 
                        order_items ON order_items.order_id = orders.id
                    LEFT JOIN 
                        (
                            SELECT 
                                order_items.id AS order_item_id,
                                GROUP_CONCAT(customization.cusName SEPARATOR ', ') AS cusNames
                            FROM 
                                order_items
                            LEFT JOIN 
                                customization ON FIND_IN_SET(customization.cusID, order_items.customizations) > 0
                            GROUP BY 
                                order_items.id
                        ) AS customization_names ON customization_names.order_item_id = order_items.id
                    GROUP BY
                        orders.id, orders.placed_on, orders.name, orders.number, orders.address, orders.total_price, orders.method, orders.payment_status

                ";

            }



                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    try
                    {
                        using (var cmd = new MySqlCommand(query, conn))
                        {
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
                lblTotal.Text = rowsCount.ToString();
            }

        

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            String query;

            if (searchTxtBox.Text != null)
            {
                query = @"
                SELECT
                    orders.id,
                    placed_on,
                    orders.name,
                    orders.number,
                    orders.address,
                    GROUP_CONCAT(
                        CONCAT(
                            order_items.quantity, 
                            'x ', 
                            order_items.name,
                            ' (',
                            order_items.size,
                            ')',
                            ' Customization: ',  
                            IFNULL(customization_names.cusNames, 'N/A')
                        ) 
                        SEPARATOR '\n'
                    ) AS Product,
                    orders.total_price,
                    orders.method,
                    orders.payment_status
                FROM 
                    orders
                JOIN 
                    order_items ON order_items.order_id = orders.id
                LEFT JOIN 
                    (
                        SELECT 
                            order_items.id AS order_item_id,
                            GROUP_CONCAT(customization.cusName SEPARATOR ', ') AS cusNames
                        FROM 
                            order_items
                        LEFT JOIN 
                            customization ON FIND_IN_SET(customization.cusID, order_items.customizations) > 0
                        GROUP BY 
                            order_items.id
                    ) AS customization_names ON customization_names.order_item_id = order_items.id
                WHERE 
                    orders.name like @filter or orders.address like @filter
                GROUP BY
                    orders.id, orders.placed_on, orders.name, orders.number, orders.address, orders.total_price, orders.method, orders.payment_status
                ";

                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    try
                    {
                        using (var cmd = new MySqlCommand(query, conn))
                        {
                            var adapter = new MySqlDataAdapter(cmd);
                            adapter.SelectCommand.Parameters.AddWithValue("filter", "%" + searchTxtBox.Text + "%");
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
                lblTotal.Text = rowsCount.ToString();
            }
            else
            {
                display();
            }
        }

        private void cmbFilter_MouseClick(object sender, MouseEventArgs e)
        {
            searchTxtBox.Text = "";
        }

        private void searchTxtBox_Click(object sender, EventArgs e)
        {
            cmbFilter.SelectedIndex = 0;
        }
    }
 }

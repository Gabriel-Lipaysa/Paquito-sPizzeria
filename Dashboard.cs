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
    public partial class Dashboard : Form
    {   
        private MainForm mainForm;
        private string connectionString = "Server=localhost;Uid=root;Database=pizza_pizza";
        public Dashboard(MainForm main)
        {   
            this.mainForm = main;
            InitializeComponent();
        }

        private void container_Load(object sender, EventArgs e)
        {
            
            
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query1 = "SELECT SUM(total_price) AS TotalPrice FROM orders WHERE payment_status='pending'";

                    using (MySqlCommand cmd = new MySqlCommand(query1, con))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblPending.Text = reader["TotalPrice"] != DBNull.Value
                                    ? "₱" + reader["TotalPrice"].ToString()
                                    : "0";
                            }
                        }
                    }

                    string query2 = "SELECT SUM(total_price) AS TotalPrice FROM orders WHERE payment_status='completed'";

                    using (MySqlCommand cmd = new MySqlCommand(query2, con))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblCompOrd.Text = reader["TotalPrice"] != DBNull.Value
                                    ? "₱" + reader["TotalPrice"].ToString()
                                    : "0";
                            }
                        }
                    }

                    string query3 = "SELECT COUNT(id) AS TotalOrd FROM orders";

                    using (MySqlCommand cmd = new MySqlCommand(query3, con))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblPlaced.Text = reader["TotalOrd"] != DBNull.Value
                                    ? reader["TotalOrd"].ToString()
                                    : "0";
                            }
                        }
                    }

                    string query4 = "SELECT COUNT(id) AS TotalProd FROM products";

                    using (MySqlCommand cmd = new MySqlCommand(query4, con))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblProducts.Text = reader["TotalProd"] != DBNull.Value
                                    ? reader["TotalProd"].ToString()
                                    : "0";
                            }
                        }
                    }

                    string query5 = "SELECT COUNT(id) AS Customers FROM user";

                    using (MySqlCommand cmd = new MySqlCommand(query5, con))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblUsers.Text = reader["Customers"] != DBNull.Value
                                    ? reader["Customers"].ToString()
                                    : "0";
                            }
                        }
                    }

                    string query6 = "SELECT COUNT(id) AS Admin FROM admin";

                    using (MySqlCommand cmd = new MySqlCommand(query6, con))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblAdmin.Text = reader["Admin"] != DBNull.Value
                                    ? reader["Admin"].ToString()
                                    : "0";
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            mainForm.LoadForm(new Products(mainForm));
        }
    }
}

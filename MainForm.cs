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
    public partial class MainForm : Form
    {
        // Define the connection string (update with your actual database details)
        private string connectionString = "Server=localhost;Uid=root;Database=pizza_db_crev;";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    con.Open();

                    // Define the query
                    string query = "SELECT SUM(total_price) AS TotalPrice FROM orders";

                    // Create a command object
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        // Execute the command and read the data
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Check if there's data to read
                            {
                                // Fetch the scalar value and update the label
                                lblTotalPrice.Text = reader["TotalPrice"] != DBNull.Value
                                    ? "₱" + reader["TotalPrice"].ToString()
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
                    // Ensure the connection is closed
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

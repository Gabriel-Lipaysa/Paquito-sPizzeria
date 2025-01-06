using MySql.Data.MySqlClient;
using Paquito_sPizzeria.Components;
using System;
using System.Windows.Forms;

namespace Paquito_sPizzeria
{
    public partial class Size : Form
    {
        private readonly string conString = "Server=localhost;Uid=root;Database=pizza_pizza";
        private readonly MainForm mainForm;
        private int id;

        public Size(MainForm main, int? sizeId = null)
        {
            id = sizeId ?? 0;
            mainForm = main;
            InitializeComponent();
        }

        private void Size_Load(object sender, EventArgs e)
        {
            if (id != 0)
            {
                btnInsert.Text = "Edit Size";
                LoadSizeDetails();
            }
            DisplayTotalSizes();
            LoadData();
        }

        private void DisplayTotalSizes()
        {
            try
            {
                using (var conn = new MySqlConnection(conString))
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand("SELECT COUNT(sizeID) AS 'Total' FROM size", conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblQty.Text = "Total: " + reader["Total"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching size count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSizeDetails()
        {
            try
            {
                using (var con = new MySqlConnection(conString))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand("SELECT * FROM size WHERE sizeID = @id", con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtCustName.Text = reader["sizename"].ToString();
                                txtCustPrice.Text = reader["sizeprice"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading size details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            try
            {
                using (var con = new MySqlConnection(conString))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand("SELECT * FROM size", con))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            flowLayoutPanel1.Controls.Clear();
                            while (reader.Read())
                            {
                                string sizeId = reader["sizeID"].ToString();
                                string name = reader["sizename"].ToString();
                                float price = float.Parse(reader["sizeprice"].ToString());
                                AddData(sizeId, name, price);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading sizes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddData(string sizeId, string name, float price)
        {
            var sizeCardComponent = new SizeCardComponent(mainForm)
            {
                Id = sizeId,
                SizeName = name,
                Price = price,
                Dock = DockStyle.Top
            };
            flowLayoutPanel1.Controls.Add(sizeCardComponent);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustName.Text) || !float.TryParse(txtCustPrice.Text, out float price))
            {
                MessageBox.Show("Please enter a valid size name and price.");
                return;
            }

            string query = id == 0
                ? "INSERT INTO size (sizename, sizeprice) VALUES (@name, @price)"
                : "UPDATE size SET sizename = @name, sizeprice = @price WHERE sizeID = @id";

            try
            {
                using (var con = new MySqlConnection(conString))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        if (id != 0) cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", txtCustName.Text);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Size saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCustName.Clear();
                txtCustPrice.Clear();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving size: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

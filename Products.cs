using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Paquito_sPizzeria
{
    public partial class Products : Form
    {
        private MainForm mainForm;
        private string imagesDirectory = System.IO.Path.Combine(Application.StartupPath, "products");
        private string connectionString = "Server=localhost;Uid=root;Database=pizza_pizza;";
         
        public Products(MainForm main)
        {
            InitializeComponent();
            mainForm = main;
        }

        private void Products_Load(object sender, EventArgs e)
        {   

            LoadData();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(id) AS 'LowStock' FROM products WHERE quantity < 10", conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblLowStock.Text = reader["LowStock"].ToString();
                        }
                    }
                }
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(id) AS 'Total' FROM products", conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblTotalProd.Text = reader["Total"].ToString();
                        }
                    }
                }
            }
        }

        private void LoadData(string search = "")
        {
            string query = "SELECT * FROM products WHERE id LIKE @search OR name LIKE @search OR price LIKE @search OR quantity LIKE @search OR description LIKE @search";

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            productLayout.Controls.Clear();
                            while (reader.Read())
                            {
                                int id = int.Parse(reader["id"].ToString());
                                string name = reader["name"].ToString();
                                float price = float.Parse(reader["price"].ToString());
                                string imageName = reader["image"].ToString();
                                int quantity = int.Parse(reader["quantity"].ToString());
                                string description = reader["description"].ToString();
                                
                                
                                Image productImage = LoadImage(imageName);

                                AddProductCard(id, name, price, quantity, description, productImage);
                            }
                        }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Error loading products: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddProductCard(int id, string name, float price, int quantity, string description, Image image)
        {
            ProductCardComponent productCard = new ProductCardComponent(mainForm)
            {
                Id = id,
                ProdName = name,
                Price = price,
                Quantity = quantity,
                Description = description,
                ProdImage = image,
                Dock = DockStyle.Top
            };
            productLayout.Controls.Add(productCard);
        }

        private Image LoadImage(string imageName)
        {
            try
            {
                string fullPath = System.IO.Path.Combine(imagesDirectory, imageName);

                if (!string.IsNullOrEmpty(fullPath) && System.IO.File.Exists(fullPath))
                {
                    return Image.FromFile(fullPath);
                }
                else
                {
                    return Properties.Resources.noImg1;
                }
            }
            catch
            {
                return Properties.Resources.noImg1;
            }
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            LoadData(search);
        }

        private void btnAdd_MouseClick(object sender, MouseEventArgs e)
        {
            mainForm.LoadForm(new AddEditProducts(mainForm));
        }

    }
}

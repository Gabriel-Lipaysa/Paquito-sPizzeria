using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Paquito_sPizzeria
{
    public partial class AddEditProducts : Form
    {
        private string imagesDirectory = Path.Combine(Application.StartupPath, "products");
        private string conString = "Server=localhost;Uid=root;Database=pizza_pizza;";
        private string imgName = "";
        private string addProdQuery = "INSERT INTO products (name, price, image, quantity, description, date) VALUES (@name, @price, @image, @qty, @desc, @date)";
        private string updateProdQuery = "UPDATE products SET name = @name, price = @price, image = @image, quantity = @qty, description = @desc, date = @date WHERE id = @id";
        private string messageAddProd = "added";
        private MainForm mainForm;
        private int prodId;

        public AddEditProducts(MainForm mainForm, int? id = null)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            prodId = id ?? 0;
        }

        private void EditProducts_Load(object sender, EventArgs e)
        {
            if (prodId == 0)
            {
                btnAddProd.Text = "Add Product";
            }
            else
            {
                btnAddProd.Text = "Edit Product";
                messageAddProd = "updated";
                LoadProductDetails();
            }
        }

        private void LoadProductDetails()
        {
            string query = "SELECT * FROM products WHERE id = @id";

            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", prodId);
                        using (var rd = cmd.ExecuteReader())
                        {
                            if (rd.Read())
                            {
                                txtBoxName.Text = rd["name"].ToString();
                                txtBoxPrice.Text = rd["price"].ToString();
                                imgName = rd["image"].ToString();
                                txtBoxQty.Text = rd["quantity"].ToString();
                                txtBoxDesc.Text = rd["description"].ToString();
                                picBox.Image = LoadImage(imgName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading product details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Image LoadImage(string imageName)
        {
            try
            {
                string fullPath = Path.Combine(imagesDirectory, imageName);

                if (File.Exists(fullPath))
                {
                    return Image.FromFile(fullPath);
                }
                else
                {
                    MessageBox.Show($"Image not found: {fullPath}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return Properties.Resources.noImg1;
                }
            }
            catch
            {
                return Properties.Resources.noImg1;
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog file = new OpenFileDialog())
            {
                file.Filter = "JPEG, PNG files|*.jpg;*.jpeg;*.png";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        picBox.Image = Image.FromFile(file.FileName);
                        imgName = Path.GetFileName(file.FileName);

                        string destinationPath = Path.Combine(imagesDirectory, imgName);
                        if (!Directory.Exists(imagesDirectory))
                        {
                            Directory.CreateDirectory(imagesDirectory);
                        }
                        File.Copy(file.FileName, destinationPath, overwrite: true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to load image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No file selected.");
                }
            }
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            string query = prodId == 0 ? addProdQuery : updateProdQuery;

            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", txtBoxName.Text);
                        cmd.Parameters.AddWithValue("@price", float.Parse(txtBoxPrice.Text));
                        cmd.Parameters.AddWithValue("@image", imgName);
                        cmd.Parameters.AddWithValue("@qty", int.Parse(txtBoxQty.Text));
                        cmd.Parameters.AddWithValue("@desc", txtBoxDesc.Text);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);

                        if (prodId != 0)
                        {
                            cmd.Parameters.AddWithValue("@id", prodId);
                        }

                        cmd.ExecuteNonQuery();

                        MessageBox.Show($"Product {messageAddProd} successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetForm();
                        mainForm.LoadForm(new Products(mainForm));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtBoxName.Text) ||
                string.IsNullOrWhiteSpace(txtBoxPrice.Text) ||
                string.IsNullOrWhiteSpace(txtBoxQty.Text) ||
                string.IsNullOrWhiteSpace(txtBoxDesc.Text))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txtBoxQty.Text, out _))
            {
                MessageBox.Show("Quantity must be an integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!float.TryParse(txtBoxPrice.Text, out _))
            {
                MessageBox.Show("Price must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (picBox.Image == null)
            {
                MessageBox.Show("Please select an image.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void ResetForm()
        {
            txtBoxName.Clear();
            txtBoxPrice.Clear();
            txtBoxQty.Clear();
            txtBoxDesc.Clear();
            picBox.Image = null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Paquito_sPizzeria
{
    public partial class Customization : Form
    {
        private MainForm mainForm;
        private string imagesDirectory = Path.Combine(Application.StartupPath, "customization");
        private string conString = "Server=localhost;Uid=root;Database=pizza_pizza";
        private string imgName = "";
        private int custId;

        public Customization(MainForm main, int? id = null)
        {
            mainForm = main;
            InitializeComponent();
            custId = id ?? 0;
        }

        private void Customization_Load(object sender, EventArgs e)
        {
            if (custId != 0)
            {
                btnInsertCust.Text = "Edit Product";
                LoadProductDetails();
            }
            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(cusID) AS 'Total' FROM customization", conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblQty.Text = "Total: " + reader["Total"].ToString();
                        }
                    }
                }
            }
            LoadCustomization();
        }

        

        private void AddCustomization(int custId, Image img, string custName, float custPrice)
        {
            CustComponent cust = new CustComponent(mainForm)
            {
                CustId = custId,
                ProdImage = img,
                CustName = custName,
                CustPrice = custPrice,
                Dock = DockStyle.Top
            };
            flowLayoutPanel1.Controls.Add(cust);
        }

        private void LoadCustomization()
        {
            string query = "SELECT * FROM customization";
            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            flowLayoutPanel1.Controls.Clear();
                            while (reader.Read())
                            {
                                int id = Convert.ToInt32(reader["cusID"]);
                                string name = reader["cusName"].ToString();
                                float price = float.Parse(reader["cusPrice"].ToString());
                                string image = reader["cusImage"].ToString();
                                ;
                                AddCustomization(id, LoadImage(image), name, price);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customization: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Image LoadImage(string imageName)
        {
            try
            {
                string fullPath = Path.Combine(imagesDirectory, imageName);
                return File.Exists(fullPath) ? Image.FromFile(fullPath) : Properties.Resources.noImg1;
            }
            catch
            {
                return Properties.Resources.noImg1;
            }
        }

        private void LoadProductDetails()
        {
            string query = "SELECT * FROM customization WHERE cusID = @id";
            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", custId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtCustName.Text = reader["cusName"].ToString();
                                txtCustPrice.Text = reader["cusPrice"].ToString();
                                imgName = reader["cusImage"].ToString();
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

                        if (!File.Exists(destinationPath))
                        {
                            File.Copy(file.FileName, destinationPath);
                        }
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

        private void btnInsertCust_Click(object sender, EventArgs e)
        {
            string query = custId == 0
                ? "INSERT INTO customization (cusName, cusPrice, cusImage) VALUES (@name, @price, @img)"
                : "UPDATE customization SET cusName = @name, cusPrice = @price, cusImage = @img WHERE cusID = @id";

            try
            {
                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        if (custId != 0)
                        {
                            cmd.Parameters.AddWithValue("@id", custId);
                        }
                        cmd.Parameters.AddWithValue("@name", txtCustName.Text);
                        cmd.Parameters.AddWithValue("@price", txtCustPrice.Text);
                        cmd.Parameters.AddWithValue("@img", imgName);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Customization saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainForm.LoadForm(new Customization(mainForm));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving customization: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtCustName.Clear();
            txtCustPrice.Clear();
            picBox.Image = Properties.Resources.noImg1;
        }
    }
}

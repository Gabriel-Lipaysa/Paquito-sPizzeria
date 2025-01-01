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
    public partial class EditProducts : Form
    {
        string conString = "server=localhost;user=root;databse=pizza_pizza";
        string imgName = "";
        public EditProducts()
        {   
            InitializeComponent();
           
        }

       

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "JPEG, PNG only|*.jpg;*.jpeg;*.png"; // Updated filter syntax
            DialogResult result = file.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    picBox.Image = Image.FromFile(file.FileName);
                    picBox.SizeMode = PictureBoxSizeMode.StretchImage; // Ensure proper display
                    imgName = file.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load image: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("No file selected or file does not exist.");
            }

        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {   
            String query = "INSERT INTO products VALUES (NULL,@name,@price,@image,@qty,@desc,@date)";

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();

                using (MySqlCommand com = new MySqlCommand(query, con))
                {
                    com.Parameters.AddWithValue("@name", txtBoxName.Text);
                    com.Parameters.AddWithValue("@price", txtBoxPrice.Text);

                    com.Parameters.AddWithValue("@qty", txtBoxQty.Text);
                    com.Parameters.AddWithValue("@desc", txtBoxDesc.Text);
                    com.Parameters.AddWithValue("@date", DateTime.Now);
                }
            }
        }
    }
}

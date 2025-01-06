using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace Paquito_sPizzeria
{
    public partial class Login : Form
    {
        string conString = "Server=localhost;Uid=root;Database=pizza_pizza";
        public Login()
        {
            InitializeComponent();
        }

        Bitmap bmpHide = Properties.Resources.hide;
        Bitmap bmpShow = Properties.Resources.show;
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();
            if (String.IsNullOrEmpty(txtUser.Text) || String.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("A required input field is empty!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                string query = "SELECT * FROM admin WHERE name=@admin AND password=@pass";
                using (MySqlCommand com = new MySqlCommand(query,con))
                {
                    com.Parameters.AddWithValue("@admin", user);
                    com.Parameters.AddWithValue("@pass", HashPasswordWithSHA1(pass));
                    using (var rd = com.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            MainForm main = new MainForm();
                            main.Show();
                            this.Hide();
                        }
                    }
                }    
                   
            }
            txtUser.Clear();
            txtPass.Clear();
        }


        private string HashPasswordWithSHA1(string password)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] bytes = sha1.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2")); // Convert to hexadecimal
                }
                return builder.ToString();
            }
        }
        
    }
}

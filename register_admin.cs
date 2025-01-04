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
    public partial class register_admin : Form
    {
        private string connectionString = "Server=localhost;Uid=root;Database=pizza_pizza;";
        public register_admin()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string query = "insert into admin(name, password) values( @name, @password)";

            if (passwordTxt.Text.Trim() == confirmPasswordTxt.Text.Trim())
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    try
                    {
                        var cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("name", nameTxt.Text.Trim());
                        cmd.Parameters.AddWithValue("password", passwordTxt.Text.Trim());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("registered successfully");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("confirm password does not match");
                passwordTxt.Clear();
                confirmPasswordTxt.Clear();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

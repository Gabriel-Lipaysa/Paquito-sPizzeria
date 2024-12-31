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
    public partial class update_admin : Form
    {
        private String connectionString = "Server=localhost;Uid=root;Database=pizza_db_crev;";

        private int this_id;
        private string this_name;
        public update_admin(int id, string name)
        {
            InitializeComponent();
            this_name = name;
            this_id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            String query = "update admin set name = @name, password = @password where id = @id";
            String query2 = "Select password from admin where id = @id";
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                var cmd2 = new MySqlCommand(query2, conn);
                cmd2.Parameters.AddWithValue("id", this_id);
                var dr = cmd2.ExecuteReader();
                if (dr.Read())
                {
                    if(oldPasswordTxt.Text == dr[0].ToString())
                    {
                        if(confirmPasswordTxt.Text == newPasswordTxt.Text)
                        {
                            try
                            {
                                if (!dr.IsClosed)
                                    dr.Close();
                                var cmd = new MySqlCommand(query, conn);
                                cmd.Parameters.AddWithValue("name", usernameTxt.Text);
                                cmd.Parameters.AddWithValue("id", this_id);
                                cmd.Parameters.AddWithValue("password", newPasswordTxt.Text);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("update successfully");
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("password does not match");
                        }
                    }
                    else
                    {
                        MessageBox.Show("incorrect old password");
                    }
                }
                
               
            }
        }

        private void update_admin_Load(object sender, EventArgs e)
        {
            usernameTxt.Text = this_name;
        }
    }
}

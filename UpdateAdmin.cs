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
    public partial class UpdateAdmin : Form
    {
        private String connectionString = "Server=localhost;Uid=root;Database=pizza_pizza";

        private int this_id;
        private string this_name;
        private MainForm mainForm;
        public UpdateAdmin(int id, string name,MainForm main)
        {
            InitializeComponent();
            this_name = name;
            this_id = id;
            this.mainForm = main;
        }
       
        private void update_admin_Load(object sender, EventArgs e)
        {
            txtUser.Text = this_name;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainForm.LoadForm(new Admin(mainForm));
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
                    if (txtOld.Text == dr[0].ToString())
                    {
                        if (txtCon.Text == txtNew.Text)
                        {
                            try
                            {
                                if (!dr.IsClosed)
                                    dr.Close();
                                var cmd = new MySqlCommand(query, conn);
                                cmd.Parameters.AddWithValue("name", txtUser.Text);
                                cmd.Parameters.AddWithValue("id", this_id);
                                cmd.Parameters.AddWithValue("password", txtNew.Text);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("update successfully");
                                mainForm.LoadForm(new Admin(mainForm));
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
    }
}

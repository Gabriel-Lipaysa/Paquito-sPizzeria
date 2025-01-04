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
using Paquito_sPizzeria.Forms;

namespace Paquito_sPizzeria
{
    public partial class Users : Form
    {
        private string connectionString = "Server=localhost;Uid=root;Database=pizza_pizza";
        private MainForm mainForm;
        public Users(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void AddUsersCard(string id, string email, string username)
        {
            UserCardComponent user = new UserCardComponent(mainForm)
            {
                Id = id,
                Email = email,
                Username = username
            };
            userLayout.Controls.Add(user);
        }
        private void LoadUsers()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {   
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM user", con))
                {
                    using(MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        userLayout.Controls.Clear();
                        while (reader.Read())
                        {
                            string id = reader["id"].ToString();
                            string email = reader["name"].ToString();
                            string username = reader["email"].ToString();
                            
                            AddUsersCard(id, email, username);
                        }
                    }
                }
            }
        }
        private void Users_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(id) AS 'Total' FROM user", conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblTotalUser.Text = "Total: " + reader["Total"].ToString();
                        }
                    }
                }
            }
            LoadUsers();
        }

        
    }
}

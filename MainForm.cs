using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Paquito_sPizzeria
{
    public partial class MainForm : Form
    {
        private string connectionString = "Server=localhost;Uid=root;Database=pizza_db_crev;";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label3.BackColor = System.Drawing.Color.Transparent;
            Dashboard test = new Dashboard();
            test.TopLevel = false;
            PanelMain.Controls.Add(test);
            test.BringToFront();
            test.Show();

            
        }

        private void Home_MouseClick(object sender, MouseEventArgs e)
        {
            label3.BackColor = System.Drawing.Color.Transparent;
            Dashboard test = new Dashboard();
            test.TopLevel = false;
            PanelMain.Controls.Add(test);
            test.BringToFront();
            test.Show();
        }

        private void Products_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Orders_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void User_MouseClick(object sender, MouseEventArgs e)
        {
            Users use = new Users();
            use.TopLevel = false;
            PanelMain.Controls.Add(use);
            use.BringToFront();
            use.Show();
        }
        private void Admin_MouseClick(object sender, MouseEventArgs e)
        {
            Admin admin = new Admin();
            admin.TopLevel = false;
            PanelMain.Controls.Add(admin);
            admin.BringToFront();
            admin.Show();
        }
    }
}

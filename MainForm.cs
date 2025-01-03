using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Paquito_sPizzeria
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label3.BackColor = System.Drawing.Color.Transparent;
            
            Dashboard test = new Dashboard(this);
            LoadForm(test);        
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard(this);
            LoadForm(dash);
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            Products products = new Products(this);
            LoadForm(products);
        }

        public void LoadForm(Form form)
        {
            PanelMain.Controls.Clear();
            form.TopLevel = false;
            PanelMain.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            LoadForm(user);
        }
    }
}

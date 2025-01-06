using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Management;
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
            Users size = new Users(this);
            LoadForm(size);
        }

        private void btnCust_Click(object sender, EventArgs e)
        {
            Customization cust = new Customization(this);
            LoadForm(cust);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            Orders ord = new Orders(this);
            LoadForm(ord);
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            Size size = new Size(this);
            LoadForm(size);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin(this);
            LoadForm(admin);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
            
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            SalesReport sales = new SalesReport();
            LoadForm(sales);
        }
    }
}

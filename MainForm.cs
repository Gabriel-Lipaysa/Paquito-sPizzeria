using MySql.Data.MySqlClient;
using System;
using System.Data;
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
            Dashboard test = new Dashboard();
            test.TopLevel = false;
            PanelMain.Controls.Add(test);
            test.BringToFront();
            test.Show();            
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            Dashboard test = new Dashboard();
            test.TopLevel = false;
            PanelMain.Controls.Add(test);
            test.BringToFront();

            test.Show();
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            PanelMain.Controls.Clear();
            Products products = new Products(this);
            products.TopLevel = false;
            PanelMain.Controls.Add(products);
            products.BringToFront();
            products.Show();    
        }

        public void LoadForm(Form form)
        {
            PanelMain.Controls.Clear();
            form.TopLevel = false;
            PanelMain.Controls.Add(form);
            form.Show();
        }
    }
}

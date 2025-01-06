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
namespace Paquito_sPizzeria.Components
{
    public partial class SizeCardComponent : UserControl
    {   
        private MainForm mainForm;
        private string conString = "Server=localhost;Uid=root;Database=pizza_pizza;";
        
        public string Id
        {
            get { return lblId.Text; }
            set { lblId.Text = value; }
        }

        public string SizeName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }
        public float Price
        {
            get { return float.Parse(lblPrice.Text); }
            set { lblPrice.Text = "₱" + value.ToString("F2"); }
        }

        public SizeCardComponent(MainForm main)
        {
            this.mainForm = main;
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            mainForm.LoadForm(new Size(mainForm,int.Parse(lblId.Text)));
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            using(MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                using(MySqlCommand cmd = new MySqlCommand("DELETE FROM size WHERE sizeID = @id",con))
                {
                    cmd.Parameters.AddWithValue("@id",Id);
                    cmd.ExecuteNonQuery();
                    mainForm.LoadForm(new Size(mainForm));
                }
            }
        }
    }
}

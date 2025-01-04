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
    public partial class CustComponent : UserControl
    {
        private MainForm mainForm;
        string conString = "Server=localhost;Uid=root;Database=pizza_pizza";
        public CustComponent(MainForm main)
        {   
            this.mainForm = main;
            InitializeComponent();
        }

        public int CustId
        {
            get { return int.Parse(lblCustId.Text); }
            set { lblCustId.Text = value.ToString(); }
        }

        public string CustName
        {
            get { return lblCustName.Text; }
            set { lblCustName.Text = value; }
        }

        public float CustPrice
        {
            get { return float.Parse(lblCustPrice.Text); }
            set { lblCustPrice.Text = "₱" + value.ToString("F2"); }
        }

        public Image ProdImage
        {
            get { return picBox.Image; }
            set { picBox.Image = value; }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {   

                mainForm.LoadForm(new Customization(mainForm, id: CustId));
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {   
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM customization WHERE cusID = @id", con))
                {
                    cmd.Parameters.AddWithValue("@id",CustId);
                    cmd.ExecuteNonQuery();
                    mainForm.LoadForm(new Customization(mainForm));
                }
            }
        }
    }
}

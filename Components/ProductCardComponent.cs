using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Paquito_sPizzeria
{
    public partial class ProductCardComponent : UserControl
    {   
        private MainForm mainForm;
        string conString = "Server=localhost;Uid=root;Database=pizza_pizza";
        public ProductCardComponent(MainForm main)
        {
            InitializeComponent();
            this.mainForm = main;
        }
        public int Id
        {
            get; set;
        }
        public string Name
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public float Price
        {
            get { return float.Parse(lblPrice.Text); }
            set { lblPrice.Text = "₱" + value.ToString("F2"); }
        }

        public int Quantity
        {
            get { return int.Parse(lblQty.Text); }
            set { lblQty.Text = value.ToString(); }
        }

        public string Description
        {
            get { return lblDesc.Text; }
            set { lblDesc.Text = value; }
        }

        private void ProductCardComponent_MouseEnter(object sender, System.EventArgs e)
        {
            panelBg.BackColor = Color.FromArgb(241, 241, 241);
        }

        public Image ProdImage
        {
            get { return picBox.Image; }
            set { picBox.Image = value; }
        }

        private void btnEdit_MouseClick(object sender, MouseEventArgs e)
        {   using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                mainForm.LoadForm(new AddEditProducts(mainForm,id: Id));
            }
                
        }

        private void btnDel_MouseClick(object sender, MouseEventArgs e)
        {
            string query = "DELETE FROM products WHERE id=@id";
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.ExecuteNonQuery();

                    var parent = this.Parent as FlowLayoutPanel;

                    if (parent != null)
                    {
                        parent.Controls.Remove(this);
                    }
                }
            }
        }


        private void panelBg_MouseHover(object sender, System.EventArgs e)
        {
            panelBg.BackColor = Color.FromArgb(241, 241, 241);
        }

        private void panelBg_MouseLeave(object sender, System.EventArgs e)
        {
            panelBg.BackColor = Color.White;
        }
    }
}

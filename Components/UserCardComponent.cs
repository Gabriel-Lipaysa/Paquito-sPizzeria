using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Paquito_sPizzeria.Forms
{
    public partial class UserCardComponent : UserControl
    {   
        private MainForm mainForm;
        string conString = "Server=localhost;Uid=root;Database=pizza_pizza";
        public UserCardComponent(MainForm main)
        {   
            this.mainForm = main;
            InitializeComponent();
        }

        public string Id
        {
            get { return lblID.Text; }
            set { lblID.Text = value; }
        }

        public string Username
        {
            get { return lblUser.Text; }
            set { lblUser.Text = value; }
        }

        public string Email
        {
            get { return lblEmail.Text; }
            set { lblEmail.Text = value; }
        }

        private void btnDel_Click(object sender, System.EventArgs e)
        {
            using(MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM user WHERE id=@id",con))
                {
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.ExecuteNonQuery();

                    mainForm.LoadForm(new Users(mainForm));
                }
            }
        }
    }
}

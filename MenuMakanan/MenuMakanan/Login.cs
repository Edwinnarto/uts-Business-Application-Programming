using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MenuMakanan
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        int kesempatan = 0;
        private void btn_Login_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-MVFVSECF\SQL2019EXPRESS;Initial Catalog=DB_MenuMakanan;Integrated Security=True");
            string query = "SELECT * FROM Login WHERE username = '" + txt_Username.Text.Trim() + "' AND Password = '" + txt_Password.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if(dtbl.Rows.Count == 1)
            {
                this.Hide();
                FrmAdminPage adminpage = new FrmAdminPage();
                adminpage.Show();
            }
            else if (this.txt_Username.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, Username tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_Username.Focus();
                kesempatan++;
            }
            else if (this.txt_Password.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, Password tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_Password.Focus();
                kesempatan++;
            }
            else
            {
                MessageBox.Show("Have Problen When Sign In, Please Check Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetLogin();
                kesempatan++;
            }
            if(kesempatan == 3)
            {
                MessageBox.Show("Try It Later, Blocked", "Blocked", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void ResetLogin()
        {
            this.txt_Username.Clear();
            //this.txt_Password.Clear();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ContinueAsGuest_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGuestPage FRG = new FrmGuestPage();
            FRG.Show();
        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckView_CheckChanged(object sender, EventArgs e)
        {
            if (CheckView.Checked)
            {
                txt_Password.UseSystemPasswordChar = false;
                var checkBox = (CheckBox)sender;
                checkBox.Text = "Show Password";
            }
            else
            {
                txt_Password.UseSystemPasswordChar = true;
                var checkBox = (CheckBox)sender;
                checkBox.Text = "Show Password";
            }
        }
    }
}

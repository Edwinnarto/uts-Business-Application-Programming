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
    public partial class ViewAllFood : Form
    {
        public ViewAllFood()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-MVFVSECF\SQL2019EXPRESS;Initial Catalog=DB_MenuMakanan;Integrated Security=True");

        private void ViewAllFood_Load(object sender, EventArgs e)
        {
            try
            {
                getdata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void getdata()
        {
            SqlCommand cmd = new SqlCommand("Select * from MenuMakanan", conn);
            DataTable dt = new DataTable();

            conn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();

            dataGridViewAllFood.DataSource = dt;
        }

        private void btn_AddFood_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminPage back = new FrmAdminPage();
            back.Show();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminPage back = new FrmAdminPage();
            back.Show();
        }

        private void btn_ViewSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewSales viewsales = new ViewSales();
            viewsales.Show();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from MenuMakanan where MenuMakanan.ID = '"+txt_Search_ViewFood.Text+"'", conn);
            DataTable dt = new DataTable();

            conn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();

            dataGridViewAllFood.DataSource = dt;
        }

        private void btn_RefreshViewFood_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from MenuMakanan", conn);
            DataTable dt = new DataTable();

            conn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();

            dataGridViewAllFood.DataSource = dt;
        }
    }
}

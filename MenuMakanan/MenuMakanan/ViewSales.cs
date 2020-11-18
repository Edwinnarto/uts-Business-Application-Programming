using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MenuMakanan
{
    public partial class ViewSales : Form
    {
        public ViewSales()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-MVFVSECF\SQL2019EXPRESS;Initial Catalog=DB_MenuMakanan;Integrated Security=True");

        private void LoadDataLeft()
        {
            SqlCommand cmd = new SqlCommand("SELECT Ordered.NoInvoice, Ordered.ID, SalesOrderedCus.NoTable, SalesOrderedCus.DateTime, SalesOrderedCus.TotalAmount FROM Ordered inner join SalesOrderedCus ON Ordered.NoInvoice = SalesOrderedCus.NoInvoice", conn);
            DataTable dt = new DataTable();

            conn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();

            dataGridViewleftsales.DataSource = dt;
        }

        private void LoadDataRight()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM MenuMakanan", conn);
            DataTable dt2 = new DataTable();

            conn.Open();

            SqlDataReader sdr2 = cmd.ExecuteReader();
            dt2.Load(sdr2);
            conn.Close();

            dataGridViewSalesRight.DataSource = dt2;
        }

        private void ViewSales_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDataLeft();
                LoadDataRight();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT Ordered.NoInvoice, Ordered.ID, SalesOrderedCus.NoTable, SalesOrderedCus.DateTime, SalesOrderedCus.TotalAmount FROM Ordered inner join SalesOrderedCus ON Ordered.NoInvoice = SalesOrderedCus.NoInvoice WHERE Ordered.NoInvoice = '"+txt_SearchNoinv.Text+"'", conn);
            DataTable dt2 = new DataTable();

            conn.Open();

            SqlDataReader sdr2 = cmd.ExecuteReader();
            dt2.Load(sdr2);
            conn.Close();

            dataGridViewleftsales.DataSource = dt2;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT Ordered.NoInvoice, Ordered.ID, SalesOrderedCus.NoTable, SalesOrderedCus.DateTime, SalesOrderedCus.TotalAmount FROM Ordered inner join SalesOrderedCus ON Ordered.NoInvoice = SalesOrderedCus.NoInvoice", conn);
            DataTable dt = new DataTable();

            conn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();

            dataGridViewleftsales.DataSource = dt;
        }

        private void dataGridViewleftsales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewleftsales.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridViewleftsales.CurrentRow.Selected = true;
                    txt_Noinv.Text = dataGridViewleftsales.Rows[e.RowIndex].Cells["NoInvoice"].FormattedValue.ToString();
                    txt_Id.Text = dataGridViewleftsales.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                    txt_Table.Text = dataGridViewleftsales.Rows[e.RowIndex].Cells["NoTable"].FormattedValue.ToString();
                    txt_Date.Text = dataGridViewleftsales.Rows[e.RowIndex].Cells["DateTime"].FormattedValue.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewSalesRight_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewSalesRight.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridViewSalesRight.CurrentRow.Selected = true;
                    txt_Food.Text = dataGridViewSalesRight.Rows[e.RowIndex].Cells["FoodName"].FormattedValue.ToString();
                    txt_PriceFood.Text = dataGridViewSalesRight.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Btn_Print_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Want To Print This Order?", "Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {                             
                MessageBox.Show("Sales Success Printed", "Printed", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_AddFood_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAdminPage frmadmin = new FrmAdminPage();
            frmadmin.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewSalesRight_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

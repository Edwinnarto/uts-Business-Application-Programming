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
using System.IO;

namespace MenuMakanan
{
    public partial class FrmGuestPage : Form
    {
        public FrmGuestPage()
        {
            InitializeComponent();
            //invoice();          
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-MVFVSECF\SQL2019EXPRESS;Initial Catalog=DB_MenuMakanan;Integrated Security=True");
        
        private void LoadData()
        {
            invoice();           
            SqlCommand cmd = new SqlCommand("Select * from MenuMakanan", conn);
            DataTable dt = new DataTable();

            conn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();

            dataGridViewMenu.DataSource = dt;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void FrmGuestPage_Load(object sender, EventArgs e)
        {
            try
            {
                txt_DateTime.Text = DateTime.Now.ToString("dd-mmmm-yyyy hh:mm:ss tt");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_NoTable_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dataGridViewMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewMenu.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridViewMenu.CurrentRow.Selected = true;
                    txt_ID2.Text = dataGridViewMenu.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                    txt_FoodName2.Text = dataGridViewMenu.Rows[e.RowIndex].Cells["FoodName"].FormattedValue.ToString();
                    txt_Price2.Text = dataGridViewMenu.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                    byte[] picture = (byte[])dataGridViewMenu.Rows[e.RowIndex].Cells["Picture"].Value;
                    MemoryStream ms = new MemoryStream(picture);
                    pictureBox2.Image = Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       
        private void btn_AddToCart_Click(object sender, EventArgs e)
        {           
            string id = txt_ID2.Text;
            string foodname = txt_FoodName2.Text;
            string price = txt_Price2.Text;
            string datetime = txt_DateTime.Text;
            string invoice = txt_NoInvoice.Text;

            int mytempdata = dataGridViewCart.Rows.Add();
            dataGridViewCart.Rows[mytempdata].Cells[0].Value = id;
            dataGridViewCart.Rows[mytempdata].Cells[1].Value = foodname;
            dataGridViewCart.Rows[mytempdata].Cells[2].Value = price;
            dataGridViewCart.Rows[mytempdata].Cells[3].Value = datetime;
            dataGridViewCart.Rows[mytempdata].Cells[4].Value = invoice;
            ResetFormGuest();

        }

        private void txt_TotalAmount_TextChanged(object sender, EventArgs e)
        {
                 
        }

        private void btn_TotalAmount_Click(object sender, EventArgs e)
        {
            try
            {
                txt_TotalAmount.Text = "0";
                for (int i = 0; i < dataGridViewCart.Rows.Count; i++)
                {
                    txt_TotalAmount.Text = Convert.ToString(double.Parse(txt_TotalAmount.Text) + double.Parse(dataGridViewCart.Rows[i].Cells[2].Value.ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewCart.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridViewCart.CurrentRow.Selected = true;
                    txt_ID2.Text = dataGridViewCart.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txt_FoodName2.Text = dataGridViewCart.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txt_Price2.Text = dataGridViewCart.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    txt_DateTime.Text = dataGridViewCart.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ResetFormGuest()
        {
            this.txt_ID2.Clear();
            this.txt_FoodName2.Clear();
            this.txt_Price2.Clear();
            pictureBox2.Image = null;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int rowindtgv = dataGridViewCart.CurrentCell.RowIndex;
            dataGridViewCart.Rows.RemoveAt(rowindtgv);                      
        }                     

        public void invoice()
        {
            try
            {                
                SqlCommand cmd = new SqlCommand("SELECT MAX(NoInvoice) from SalesOrderedCus", conn);

                conn.Open();
                var maxid = cmd.ExecuteScalar() as String;

                if (maxid == null)
                {
                    txt_NoInvoice.Text = "T-000001";
                }
                else
                {
                    int intergval = int.Parse(maxid.Substring(2, 6));
                    intergval++;
                    txt_NoInvoice.Text = String.Format("T-{0:000000}", intergval);
                }
                conn.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_ID2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_DateTime_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_CheckOut_Click(object sender, EventArgs e)
        {
            if (this.txt_NoTable.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, Please Fill No Table", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_NoTable.Focus();
            }

            else if (this.txt_TotalAmount.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, Please Click Total Amount Button", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_TotalAmount.Focus();
            }

            else
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO SalesOrderedCus VALUES" + "(@NoInvoice, @NoTable, @DateTime, @TotalAmount)", conn);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@NoInvoice", this.txt_NoInvoice.Text.Trim());
                cmd.Parameters.AddWithValue("@NoTable", this.txt_NoTable.Text.Trim());
                cmd.Parameters.AddWithValue("@DateTime", this.txt_DateTime.Text.Trim());
                cmd.Parameters.AddWithValue("@TotalAmount", this.txt_TotalAmount.Text.Trim());

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Order Successfully Created", "CheckOut", MessageBoxButtons.OK, MessageBoxIcon.Information);

                for (int i = 0; i < dataGridViewCart.Rows.Count; i++)
                {
                    SqlCommand cmdd = new SqlCommand(@"INSERT INTO Ordered (ID,NoInvoice)Values('" + dataGridViewCart.Rows[i].Cells[0].Value + "','" + dataGridViewCart.Rows[i].Cells[4].Value + "')", conn);
                    conn.Open();
                    cmdd.ExecuteNonQuery();
                    conn.Close();
                }
                dataGridViewCart.Rows.Clear();
                this.txt_NoTable.Clear();
                this.txt_TotalAmount.Clear();

                LoadData();
            }
        }

        private void dataGridViewCart_RowAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
           
        }

        private void txt_NoTable_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

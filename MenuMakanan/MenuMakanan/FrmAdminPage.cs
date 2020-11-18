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
    public partial class FrmAdminPage : Form
    {
        public FrmAdminPage()
        {
            InitializeComponent();           
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-MVFVSECF\SQL2019EXPRESS;Initial Catalog=DB_MenuMakanan;Integrated Security=True");
        
        private void LoadData() 
        {
            //load data ke datagridview dari database
            SqlCommand cmd = new SqlCommand("Select * from MenuMakanan", conn);
            DataTable dt = new DataTable();

            conn.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();

            dataGridViewAddFood.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (this.txt_ID.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, ID Food tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_ID.Focus();
            }

            else if (this.txt_FoodName.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, Food Name tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_FoodName.Focus();
            }

            else if (this.txt_Price.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, Price tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_Price.Focus();
            }

            else if (this.txt_Description.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, Description tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_Description.Focus();
            }

            else
            {
                try
                {
                    byte[] picture = null;
                    FileStream streem = new FileStream(picturelocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(streem);
                    picture = brs.ReadBytes((int)streem.Length);

                    SqlCommand cmd = new SqlCommand("INSERT INTO MenuMakanan VALUES " +
                        "(@ID, @FoodName, @Price, @Description, @Picture)", conn);

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ID", this.txt_ID.Text.Trim());
                    cmd.Parameters.AddWithValue("@FoodName", this.txt_FoodName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Price", this.txt_Price.Text.Trim());
                    cmd.Parameters.AddWithValue("@Description", this.txt_Description.Text.Trim());
                    cmd.Parameters.AddWithValue("@Picture", picture);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("New Food Successfully created and saved in database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ResetFormClean();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }               
            }
        }
               
        private void btn_Cancel_Click(object sender, EventArgs e)
        {   
            ResetFormClean();    
        }

        private void ResetFormClean()
        {           
            this.txt_ID.Clear();
            this.txt_FoodName.Clear();
            this.txt_Price.Clear();
            this.txt_Description.Clear();
            pictureBox1.Image = null;
            
            //txt_ID.Focus();
            //txt_FoodName.Focus();
            //txt_Price.Focus();
        }

        string picturelocation = "";
        private void btn_Upload_Click(object sender, EventArgs e)
        {
            //foto yang dipilih dari file 
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                //tampilkan dari file (dialog)
                picturelocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = picturelocation;

            }
        }

        private void FrmAdminPage_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_Price_Keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dataGridViewAddFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewAddFood.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dataGridViewAddFood.CurrentRow.Selected = true;
                    txt_ID.Text = dataGridViewAddFood.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                    txt_FoodName.Text = dataGridViewAddFood.Rows[e.RowIndex].Cells["FoodName"].FormattedValue.ToString();
                    txt_Price.Text = dataGridViewAddFood.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                    txt_Description.Text = dataGridViewAddFood.Rows[e.RowIndex].Cells["Description"].FormattedValue.ToString();
                    byte[] picture = (byte[])dataGridViewAddFood.Rows[e.RowIndex].Cells["Picture"].Value;
                    MemoryStream ms = new MemoryStream(picture);
                    pictureBox1.Image = Image.FromStream(ms);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (this.txt_ID.Text.Trim() == "")
            {
                MessageBox.Show("Please Select One In FoodName Cells For Update", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_ID.Focus();
            }

            else if (this.txt_FoodName.Text.Trim() == "")
            {
                MessageBox.Show("Please Select One In FoodName Cells For Update", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_FoodName.Focus();
            }

            else if (this.txt_Price.Text.Trim() == "")
            {
                MessageBox.Show("Please Select One In FoodName Cells For Update", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_Price.Focus();
            }

            else if (this.txt_Description.Text.Trim() == "")
            {
                MessageBox.Show("Please Select One In FoodName Cells For Update", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_Description.Focus();
            }

            else
            {
                if (MessageBox.Show("Are You Want To Update This Data From Database ?", "Updated", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    SqlCommand cmd = new SqlCommand("UPDATE MenuMakanan SET FoodName = @FoodName, Price = @Price, Description = @Description, Picture = @Picture  WHERE ID = @ID", conn);

                    MemoryStream stream = new MemoryStream();
                    pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] picture = stream.ToArray();
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ID", this.txt_ID.Text.Trim());
                    cmd.Parameters.AddWithValue("@FoodName", this.txt_FoodName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Price", this.txt_Price.Text.Trim());
                    cmd.Parameters.AddWithValue("@Description", this.txt_Description.Text.Trim());
                    cmd.Parameters.AddWithValue("@Picture", picture);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Food Successfully Updated and saved in database", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ResetFormClean();
                }
            }                               
        }

        private void btn_ViewAllFood_Click(object sender, EventArgs e)
        {
                this.Hide();
                ViewAllFood val = new ViewAllFood();          
                val.Show();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (this.txt_ID.Text.Trim() == "")
            {
                MessageBox.Show("Please Select One In FoodName Cells For Delete", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_ID.Focus();
            }

            else if (this.txt_FoodName.Text.Trim() == "")
            {
                MessageBox.Show("Please Select One In FoodName Cells For Delete", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_FoodName.Focus();
            }

            else if (this.txt_Price.Text.Trim() == "")
            {
                MessageBox.Show("Please Select One In FoodName Cells For Delete", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_Price.Focus();
            }

            else if (this.txt_Description.Text.Trim() == "")
            {
                MessageBox.Show("Please Select One In FoodName Cells For Delete", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_Description.Focus();
            }
            else {
                try
                {
                    if (MessageBox.Show("Are You Want To Delete This Data From Database ?", "Deleted", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        SqlCommand cmd = new SqlCommand("DELETE FROM MenuMakanan WHERE ID = @ID", conn);

                        MemoryStream stream = new MemoryStream();
                        pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] picture = stream.ToArray();
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@ID", this.txt_ID.Text.Trim());
                        cmd.Parameters.AddWithValue("@FoodName", this.txt_FoodName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Price", this.txt_Price.Text.Trim());
                        cmd.Parameters.AddWithValue("@Description", this.txt_Description.Text.Trim());
                        cmd.Parameters.AddWithValue("@Picture", picture);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Food Successfully Deleted From The Database", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ResetFormClean();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Cannot Delete This Food While Customer Already Order", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                
                }
        }

        private void btn_ViewSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewSales viewsales = new ViewSales();
            viewsales.Show();
        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {

            if (this.txt_ID.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, ID Food tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_ID.Focus();
            }

            else if (this.txt_FoodName.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, Food Name tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_FoodName.Focus();
            }

            else if (this.txt_Price.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, Price tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_Price.Focus();
            }

            else if (this.txt_Description.Text.Trim() == "")
            {
                MessageBox.Show("Sorry, Description tidak boleh kosong ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_Description.Focus();
            }
            else
            {
                try
                {
                    byte[] picture = null;
                    FileStream streem = new FileStream(picturelocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(streem);
                    picture = brs.ReadBytes((int)streem.Length);

                    SqlCommand cmd = new SqlCommand("INSERT INTO HideShowMenu VALUES " +
                        "(@ID, @FoodName, @Price, @Description, @Picture)", conn);

                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@ID", this.txt_ID.Text.Trim());
                    cmd.Parameters.AddWithValue("@FoodName", this.txt_FoodName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Price", this.txt_Price.Text.Trim());
                    cmd.Parameters.AddWithValue("@Description", this.txt_Description.Text.Trim());
                    cmd.Parameters.AddWithValue("@Picture", picture);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Food Successfully Hide", "Hide", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ResetFormClean();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btn_ViewHideItems_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_FoodName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

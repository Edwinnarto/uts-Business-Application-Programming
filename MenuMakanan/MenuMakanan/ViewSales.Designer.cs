namespace MenuMakanan
{
    partial class ViewSales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_AddFood = new System.Windows.Forms.Button();
            this.dataGridViewleftsales = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SearchNoinv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Noinv = new System.Windows.Forms.TextBox();
            this.txt_Food = new System.Windows.Forms.TextBox();
            this.txt_PriceFood = new System.Windows.Forms.TextBox();
            this.txt_Date = new System.Windows.Forms.TextBox();
            this.txt_Table = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dataGridViewSalesRight = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewleftsales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesRight)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AddFood
            // 
            this.btn_AddFood.Location = new System.Drawing.Point(12, 21);
            this.btn_AddFood.Name = "btn_AddFood";
            this.btn_AddFood.Size = new System.Drawing.Size(75, 23);
            this.btn_AddFood.TabIndex = 0;
            this.btn_AddFood.Text = "Add Food";
            this.btn_AddFood.UseVisualStyleBackColor = true;
            this.btn_AddFood.Click += new System.EventHandler(this.btn_AddFood_Click);
            // 
            // dataGridViewleftsales
            // 
            this.dataGridViewleftsales.AllowUserToAddRows = false;
            this.dataGridViewleftsales.AllowUserToDeleteRows = false;
            this.dataGridViewleftsales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewleftsales.Location = new System.Drawing.Point(12, 65);
            this.dataGridViewleftsales.Name = "dataGridViewleftsales";
            this.dataGridViewleftsales.ReadOnly = true;
            this.dataGridViewleftsales.Size = new System.Drawing.Size(366, 349);
            this.dataGridViewleftsales.TabIndex = 1;
            this.dataGridViewleftsales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewleftsales_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "No.Invoice";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_SearchNoinv
            // 
            this.txt_SearchNoinv.Location = new System.Drawing.Point(575, 25);
            this.txt_SearchNoinv.Name = "txt_SearchNoinv";
            this.txt_SearchNoinv.Size = new System.Drawing.Size(100, 20);
            this.txt_SearchNoinv.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "No. Invoice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "FoodName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(522, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date Time";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 505);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "No. Table";
            // 
            // txt_Noinv
            // 
            this.txt_Noinv.Location = new System.Drawing.Point(83, 469);
            this.txt_Noinv.Name = "txt_Noinv";
            this.txt_Noinv.ReadOnly = true;
            this.txt_Noinv.Size = new System.Drawing.Size(93, 20);
            this.txt_Noinv.TabIndex = 11;
            // 
            // txt_Food
            // 
            this.txt_Food.Location = new System.Drawing.Point(590, 436);
            this.txt_Food.Name = "txt_Food";
            this.txt_Food.ReadOnly = true;
            this.txt_Food.Size = new System.Drawing.Size(169, 20);
            this.txt_Food.TabIndex = 12;
            // 
            // txt_PriceFood
            // 
            this.txt_PriceFood.Location = new System.Drawing.Point(590, 469);
            this.txt_PriceFood.Name = "txt_PriceFood";
            this.txt_PriceFood.ReadOnly = true;
            this.txt_PriceFood.Size = new System.Drawing.Size(169, 20);
            this.txt_PriceFood.TabIndex = 13;
            // 
            // txt_Date
            // 
            this.txt_Date.Location = new System.Drawing.Point(590, 502);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.ReadOnly = true;
            this.txt_Date.Size = new System.Drawing.Size(169, 20);
            this.txt_Date.TabIndex = 14;
            this.txt_Date.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txt_Table
            // 
            this.txt_Table.Location = new System.Drawing.Point(83, 502);
            this.txt_Table.Name = "txt_Table";
            this.txt_Table.ReadOnly = true;
            this.txt_Table.Size = new System.Drawing.Size(169, 20);
            this.txt_Table.TabIndex = 15;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(681, 23);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 16;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dataGridViewSalesRight
            // 
            this.dataGridViewSalesRight.AllowUserToAddRows = false;
            this.dataGridViewSalesRight.AllowUserToDeleteRows = false;
            this.dataGridViewSalesRight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalesRight.Location = new System.Drawing.Point(393, 65);
            this.dataGridViewSalesRight.Name = "dataGridViewSalesRight";
            this.dataGridViewSalesRight.ReadOnly = true;
            this.dataGridViewSalesRight.Size = new System.Drawing.Size(366, 349);
            this.dataGridViewSalesRight.TabIndex = 17;
            this.dataGridViewSalesRight.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSalesRight_CellClick);
            this.dataGridViewSalesRight.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSalesRight_CellContentClick);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(101, 21);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 18;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(83, 436);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.ReadOnly = true;
            this.txt_Id.Size = new System.Drawing.Size(93, 20);
            this.txt_Id.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "ID";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(343, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 69);
            this.button1.TabIndex = 21;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Btn_Print_Click);
            // 
            // ViewSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(768, 558);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.dataGridViewSalesRight);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Table);
            this.Controls.Add(this.txt_Date);
            this.Controls.Add(this.txt_PriceFood);
            this.Controls.Add(this.txt_Food);
            this.Controls.Add(this.txt_Noinv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_SearchNoinv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewleftsales);
            this.Controls.Add(this.btn_AddFood);
            this.Name = "ViewSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewSales";
            this.Load += new System.EventHandler(this.ViewSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewleftsales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddFood;
        private System.Windows.Forms.DataGridView dataGridViewleftsales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SearchNoinv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Noinv;
        private System.Windows.Forms.TextBox txt_Food;
        private System.Windows.Forms.TextBox txt_PriceFood;
        private System.Windows.Forms.TextBox txt_Date;
        private System.Windows.Forms.TextBox txt_Table;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dataGridViewSalesRight;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}
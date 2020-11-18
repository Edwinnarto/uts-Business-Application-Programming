namespace MenuMakanan
{
    partial class ViewAllFood
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
            this.dataGridViewAllFood = new System.Windows.Forms.DataGridView();
            this.btn_AddFood = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_ViewSales = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Search_ViewFood = new System.Windows.Forms.TextBox();
            this.btn_Search_ViewFood = new System.Windows.Forms.Button();
            this.txt_RefreshViewFood = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllFood)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAllFood
            // 
            this.dataGridViewAllFood.AllowUserToAddRows = false;
            this.dataGridViewAllFood.AllowUserToDeleteRows = false;
            this.dataGridViewAllFood.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewAllFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAllFood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewAllFood.ColumnHeadersHeight = 50;
            this.dataGridViewAllFood.Location = new System.Drawing.Point(12, 71);
            this.dataGridViewAllFood.Name = "dataGridViewAllFood";
            this.dataGridViewAllFood.ReadOnly = true;
            this.dataGridViewAllFood.RowTemplate.Height = 300;
            this.dataGridViewAllFood.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAllFood.Size = new System.Drawing.Size(744, 496);
            this.dataGridViewAllFood.TabIndex = 0;
            // 
            // btn_AddFood
            // 
            this.btn_AddFood.Location = new System.Drawing.Point(225, 27);
            this.btn_AddFood.Name = "btn_AddFood";
            this.btn_AddFood.Size = new System.Drawing.Size(85, 23);
            this.btn_AddFood.TabIndex = 1;
            this.btn_AddFood.Text = "Add Food";
            this.btn_AddFood.UseVisualStyleBackColor = true;
            this.btn_AddFood.Click += new System.EventHandler(this.btn_AddFood_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(12, 26);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(85, 23);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_ViewSales
            // 
            this.btn_ViewSales.Location = new System.Drawing.Point(118, 27);
            this.btn_ViewSales.Name = "btn_ViewSales";
            this.btn_ViewSales.Size = new System.Drawing.Size(85, 23);
            this.btn_ViewSales.TabIndex = 3;
            this.btn_ViewSales.Text = "View Sales";
            this.btn_ViewSales.UseVisualStyleBackColor = true;
            this.btn_ViewSales.Click += new System.EventHandler(this.btn_ViewSales_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(516, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID Food";
            // 
            // txt_Search_ViewFood
            // 
            this.txt_Search_ViewFood.Location = new System.Drawing.Point(567, 29);
            this.txt_Search_ViewFood.Name = "txt_Search_ViewFood";
            this.txt_Search_ViewFood.Size = new System.Drawing.Size(108, 20);
            this.txt_Search_ViewFood.TabIndex = 5;
            // 
            // btn_Search_ViewFood
            // 
            this.btn_Search_ViewFood.Location = new System.Drawing.Point(681, 27);
            this.btn_Search_ViewFood.Name = "btn_Search_ViewFood";
            this.btn_Search_ViewFood.Size = new System.Drawing.Size(75, 23);
            this.btn_Search_ViewFood.TabIndex = 6;
            this.btn_Search_ViewFood.Text = "Search";
            this.btn_Search_ViewFood.UseVisualStyleBackColor = true;
            this.btn_Search_ViewFood.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_RefreshViewFood
            // 
            this.txt_RefreshViewFood.Location = new System.Drawing.Point(332, 27);
            this.txt_RefreshViewFood.Name = "txt_RefreshViewFood";
            this.txt_RefreshViewFood.Size = new System.Drawing.Size(75, 23);
            this.txt_RefreshViewFood.TabIndex = 7;
            this.txt_RefreshViewFood.Text = "Refresh";
            this.txt_RefreshViewFood.UseVisualStyleBackColor = true;
            this.txt_RefreshViewFood.Click += new System.EventHandler(this.btn_RefreshViewFood_Click);
            // 
            // ViewAllFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 588);
            this.Controls.Add(this.txt_RefreshViewFood);
            this.Controls.Add(this.btn_Search_ViewFood);
            this.Controls.Add(this.txt_Search_ViewFood);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ViewSales);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_AddFood);
            this.Controls.Add(this.dataGridViewAllFood);
            this.Name = "ViewAllFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAllFood";
            this.Load += new System.EventHandler(this.ViewAllFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAllFood;
        private System.Windows.Forms.Button btn_AddFood;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_ViewSales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Search_ViewFood;
        private System.Windows.Forms.Button btn_Search_ViewFood;
        private System.Windows.Forms.Button txt_RefreshViewFood;
    }
}
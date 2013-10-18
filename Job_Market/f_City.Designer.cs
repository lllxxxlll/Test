namespace Job_Market
{
    partial class f_City
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
            this.tb_AddCity = new System.Windows.Forms.TextBox();
            this.bt_AddCity = new System.Windows.Forms.Button();
            this.bt_DelCity = new System.Windows.Forms.Button();
            this.dgv_City = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_EditCity = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_City)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_AddCity
            // 
            this.tb_AddCity.Location = new System.Drawing.Point(17, 22);
            this.tb_AddCity.Name = "tb_AddCity";
            this.tb_AddCity.Size = new System.Drawing.Size(103, 20);
            this.tb_AddCity.TabIndex = 0;
            // 
            // bt_AddCity
            // 
            this.bt_AddCity.Location = new System.Drawing.Point(126, 22);
            this.bt_AddCity.Name = "bt_AddCity";
            this.bt_AddCity.Size = new System.Drawing.Size(103, 23);
            this.bt_AddCity.TabIndex = 1;
            this.bt_AddCity.Text = "Добавить город";
            this.bt_AddCity.UseVisualStyleBackColor = true;
            this.bt_AddCity.Click += new System.EventHandler(this.bt_AddCity_Click);
            // 
            // bt_DelCity
            // 
            this.bt_DelCity.Location = new System.Drawing.Point(235, 22);
            this.bt_DelCity.Name = "bt_DelCity";
            this.bt_DelCity.Size = new System.Drawing.Size(103, 23);
            this.bt_DelCity.TabIndex = 4;
            this.bt_DelCity.Text = "Удалить город";
            this.bt_DelCity.UseVisualStyleBackColor = true;
            this.bt_DelCity.Click += new System.EventHandler(this.bt_DelCity_Click);
            // 
            // dgv_City
            // 
            this.dgv_City.AllowUserToAddRows = false;
            this.dgv_City.AllowUserToDeleteRows = false;
            this.dgv_City.BackgroundColor = System.Drawing.Color.White;
            this.dgv_City.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_City.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.City});
            this.dgv_City.GridColor = System.Drawing.Color.White;
            this.dgv_City.Location = new System.Drawing.Point(126, 51);
            this.dgv_City.Name = "dgv_City";
            this.dgv_City.RowHeadersVisible = false;
            this.dgv_City.Size = new System.Drawing.Size(103, 223);
            this.dgv_City.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "tbl_City_ID";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // City
            // 
            this.City.DataPropertyName = "tbl_City_Name";
            this.City.HeaderText = "Города";
            this.City.Name = "City";
            // 
            // bt_EditCity
            // 
            this.bt_EditCity.Location = new System.Drawing.Point(236, 51);
            this.bt_EditCity.Name = "bt_EditCity";
            this.bt_EditCity.Size = new System.Drawing.Size(102, 23);
            this.bt_EditCity.TabIndex = 5;
            this.bt_EditCity.Text = "Переименовать";
            this.bt_EditCity.UseVisualStyleBackColor = true;
            this.bt_EditCity.Click += new System.EventHandler(this.bt_EditCity_Click);
            // 
            // f_City
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 397);
            this.Controls.Add(this.bt_EditCity);
            this.Controls.Add(this.bt_DelCity);
            this.Controls.Add(this.dgv_City);
            this.Controls.Add(this.bt_AddCity);
            this.Controls.Add(this.tb_AddCity);
            this.Name = "f_City";
            this.Text = "f_City";
            this.Load += new System.EventHandler(this.f_City_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_City)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_AddCity;
        private System.Windows.Forms.Button bt_AddCity;
        private System.Windows.Forms.Button bt_DelCity;
        private System.Windows.Forms.DataGridView dgv_City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.Button bt_EditCity;
    }
}
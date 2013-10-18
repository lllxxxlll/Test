namespace Job_Market
{
    partial class f_City_Edit
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
            this.tb_City_Edit = new System.Windows.Forms.TextBox();
            this.bt_City_Edit_OK = new System.Windows.Forms.Button();
            this.bt_City_Edit_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_City_Edit
            // 
            this.tb_City_Edit.Location = new System.Drawing.Point(77, 12);
            this.tb_City_Edit.Name = "tb_City_Edit";
            this.tb_City_Edit.Size = new System.Drawing.Size(128, 20);
            this.tb_City_Edit.TabIndex = 0;
            // 
            // bt_City_Edit_OK
            // 
            this.bt_City_Edit_OK.Location = new System.Drawing.Point(12, 41);
            this.bt_City_Edit_OK.Name = "bt_City_Edit_OK";
            this.bt_City_Edit_OK.Size = new System.Drawing.Size(104, 23);
            this.bt_City_Edit_OK.TabIndex = 1;
            this.bt_City_Edit_OK.Text = "OK";
            this.bt_City_Edit_OK.UseVisualStyleBackColor = true;
            this.bt_City_Edit_OK.Click += new System.EventHandler(this.bt_City_Edit_OK_Click);
            // 
            // bt_City_Edit_Cancel
            // 
            this.bt_City_Edit_Cancel.Location = new System.Drawing.Point(167, 41);
            this.bt_City_Edit_Cancel.Name = "bt_City_Edit_Cancel";
            this.bt_City_Edit_Cancel.Size = new System.Drawing.Size(105, 23);
            this.bt_City_Edit_Cancel.TabIndex = 2;
            this.bt_City_Edit_Cancel.Text = "Отмена";
            this.bt_City_Edit_Cancel.UseVisualStyleBackColor = true;
            this.bt_City_Edit_Cancel.Click += new System.EventHandler(this.bt_City_Edit_Cancel_Click);
            // 
            // f_City_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 80);
            this.Controls.Add(this.bt_City_Edit_Cancel);
            this.Controls.Add(this.bt_City_Edit_OK);
            this.Controls.Add(this.tb_City_Edit);
            this.Name = "f_City_Edit";
            this.Text = "f_City_Edit";
            this.Load += new System.EventHandler(this.f_City_Edit_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_City_Edit;
        private System.Windows.Forms.Button bt_City_Edit_OK;
        private System.Windows.Forms.Button bt_City_Edit_Cancel;
    }
}
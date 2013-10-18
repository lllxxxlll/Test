using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Job_Market
{
    public partial class f_City_Edit : Form
    {
        string Editing, Edited;
        int ID;
        public f_City_Edit(string Editing, int ID)
        {
            InitializeComponent();
            this.Editing = Editing;
            this.ID = ID;

            
        }

        private void f_City_Edit_Load_1(object sender, EventArgs e)
        {
            tb_City_Edit.Text = Editing;
        }

        public void bt_City_Edit_OK_Click(object sender, EventArgs e)
        {
            Edited = tb_City_Edit.Text;
            Class_SQL_Quary obj = new Class_SQL_Quary();
            obj.SQL_Quary("SPU_CITY_EDIT",ID,Edited);
            MessageBox.Show("Город изменён");
            Close();
        }

        private void bt_City_Edit_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

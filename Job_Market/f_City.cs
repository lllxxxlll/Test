using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Job_Market
{
    public partial class f_City : Form
    {
        public f_City()
        {
            InitializeComponent();
        }

       public Class_SQL_Quary obj = new Class_SQL_Quary();

        private void bt_AddCity_Click(object sender, EventArgs e)
        {
            if (tb_AddCity.Text != "")
            {
                obj.SQL_Quary("SPU_CITY_ADD", tb_AddCity.Text);
                RefreshDataGrid();
                tb_AddCity.Text = "";
                MessageBox.Show("Город добавлен");
            }
            else
                MessageBox.Show("Поле добавления города не должно быть пустым");
            
        }

        private void bt_DelCity_Click(object sender, EventArgs e)
        {
            if (dgv_City.CurrentRow != null)
            {
                //SqlCommand _cmd = new SqlCommand();
                //_cmd.CommandType = CommandType.StoredProcedure; ;
                //_cmd.Connection = SQLConnect._connect;
                //_cmd.CommandText = "SPU_CITY_DEL";
                //_cmd.Parameters.Add(new SqlParameter("@ID", ((DataGridViewRow)dgv_City.CurrentRow).Cells["Id"].Value));
                //_cmd.Connection.Open();
                //_cmd.ExecuteNonQuery();
                //_cmd.Connection.Close();
                obj.SQL_Quary("SPU_CITY_DEL", (int)dgv_City.CurrentRow.Cells["Id"].Value);
                RefreshDataGrid();
                MessageBox.Show("Город удалён");
            }
            else MessageBox.Show("Спрвочник городов пуст");
            RefreshDataGrid();
        }

        private void f_City_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {

            dgv_City.DataSource = obj.SQL_Quary("SPU_CITY_SEL");
        }

        private void bt_EditCity_Click(object sender, EventArgs e)
        {
            Form _f_City_Edit = new f_City_Edit((string)dgv_City.CurrentCell.Value, (int)dgv_City.CurrentRow.Cells["Id"].Value);
            _f_City_Edit.ShowDialog();
            RefreshDataGrid();
           
        }
    }
}

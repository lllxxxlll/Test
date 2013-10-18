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
    public partial class f_Authorization : Form
    {
        public bool LogIN=false;
        Form _f_City = new f_City();
        public f_Authorization()

        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand _cmd = new SqlCommand();
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = SQLConnect._connect;
            _cmd.CommandText = "SELECT * FROM tbl_User inner join tbl_Password on tbl_Password.tbl_User_ID = tbl_User.tbl_User_ID WHERE tbl_User_Login='"+tb_Login.Text+"' and tbl_Password_Pass='"+tb_Password.Text+"'";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand=_cmd;
            DataTable _tbl = new DataTable();
            adapter.Fill(_tbl);
            if(_tbl.Rows.Count != 0)
            {
                MessageBox.Show("Вход выполнен");
                _f_City.Show();

            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }

            //if (LogIN) _f_City.Show();
            
            //this.Close();

        }
    }
}

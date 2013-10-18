using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Job_Market
{
   public class Class_SQL_Quary
    {
        //string _CommandText;
        //string Name = null;
        //int ID;

        //public Class_SQL_Quary(string _CommandText, string Name = null)
        //{
        //    this._CommandText = _CommandText;
        //    this.Name = Name;
        //}

        //public Class_SQL_Quary(string _CommandText, int ID)
        //{
        //    this._CommandText = _CommandText;
        //    this.ID = ID;
        //}

        public DataTable SQL_Quary(string _CommandText, string Name = null)
        {
            SqlCommand _cmd = new SqlCommand();
            if (Name != null)
            {
                SqlParameter pr = new SqlParameter("@Name", Name);
                _cmd.Parameters.Add(pr);
            }
            _cmd.CommandType = CommandType.StoredProcedure; ;
            _cmd.Connection = SQLConnect._connect;
            _cmd.CommandText = _CommandText;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = _cmd;
            DataTable _tbl = new DataTable();
            adapter.Fill(_tbl);
            return _tbl;
        }

        public DataTable SQL_Quary(string _CommandText, int ID)
        {
            SqlCommand _cmd = new SqlCommand();
            SqlParameter pr = new SqlParameter("@ID", ID);
            _cmd.Parameters.Add(pr);
            _cmd.CommandType = CommandType.StoredProcedure; ;
            _cmd.Connection = SQLConnect._connect;
            _cmd.CommandText = _CommandText;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = _cmd;
            DataTable _tbl = new DataTable();
            adapter.Fill(_tbl);
            return _tbl;
        }

        public DataTable SQL_Quary(string _CommandText, int ID, string Name)
        {
            SqlCommand _cmd = new SqlCommand();
            SqlParameter pr1 = new SqlParameter("@ID", ID);
            SqlParameter pr2 = new SqlParameter("@Name", Name);
            _cmd.Parameters.Add(pr1);
            _cmd.Parameters.Add(pr2);
            _cmd.CommandType = CommandType.StoredProcedure; ;
            _cmd.Connection = SQLConnect._connect;
            _cmd.CommandText = _CommandText;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = _cmd;
            DataTable _tbl = new DataTable();
            adapter.Fill(_tbl);
            return _tbl;
        }
    }
}

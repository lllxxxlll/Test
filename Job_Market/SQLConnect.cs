using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Job_Market
{
    public static class SQLConnect
    {
        public static SqlConnection _connect = new SqlConnection("Data Source=VADIM;Initial Catalog=Job_Market;Integrated Security=True");
    }
}

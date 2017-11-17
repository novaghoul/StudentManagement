using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class nConnect
    {
        public static SqlConnection Ct()
        {
            string Cn = "Data Source = DELL_1997; Initial Catalog = QLDN; Integrated Security = True";
            SqlConnection conn = new SqlConnection(Cn);
            conn.Open();
            return conn;
        }

        public static DataTable TakeDL(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, Ct());
            da.Fill(dt);
            return dt;
        }
    }
}

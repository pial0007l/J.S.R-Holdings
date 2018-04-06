using System;
using System.Data.SqlClient;

namespace J.S.R_Holdings.Database
{
    class DataAccess
    {
        static SqlConnection conn;

        static SqlConnection Connection
        {
            get
            {
                conn = new SqlConnection(J.S.R_Holdings.Database.Properties.Settings.Default.ConnectionStringJSR);
                conn.Open();
                return conn;
            }
        }

        public static int ExecuteQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, Connection);
            return cmd.ExecuteNonQuery();
        }

        public static SqlDataReader GetData(string query)
        {
            SqlCommand cmd = new SqlCommand(query, Connection);
            return cmd.ExecuteReader();
        }
    }
}

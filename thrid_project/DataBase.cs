using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace thrid_project
{
    public class DataBase
    {
        readonly SqlConnection sqlConnection = new SqlConnection(GetConnectionString());

        public void ConnectionOpen()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void ConnectionClose()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetSqlConnection()
        {
            return sqlConnection;
        }

        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["base"].ConnectionString;
        }
    }
}

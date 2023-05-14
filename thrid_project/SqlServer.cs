using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thrid_project
{
    public class SQLServer
    {
        public static DataTable ExecuteQuerySelect(string query)
        {
            DataBase dataBase = new DataBase();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand(query, dataBase.GetSqlConnection());

            adapter.SelectCommand = command;

            adapter.Fill(table);
            return table;
        }
        public static void ExecuteQueryInsert_Update(string query)
        {
            DataBase dataBase = new DataBase();
            dataBase.ConnectionOpen();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand(query, dataBase.GetSqlConnection());
            command.ExecuteNonQuery();
            dataBase.ConnectionClose();
        }
        public static void ExecuteQueryDelete(string query)
        {
            DataBase dataBase = new DataBase();
            dataBase.ConnectionOpen();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand(query, dataBase.GetSqlConnection());
            command.ExecuteNonQuery();
            dataBase.ConnectionClose();
        }
    }
}

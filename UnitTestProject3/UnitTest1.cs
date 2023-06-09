﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Data.SqlClient;
using thrid_project;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FindsOneMatchingRowInDatabase()
        {
            string query = $"select * from Accounts where Login = '1' and Password = '1'";
            DataTable table = new DataTable();
            table = SQLServer.ExecuteQuerySelect(query);
            Assert.IsTrue(table.Rows.Count == 1);
        }

        [TestMethod]
        public void CheckUpdatesInDatabase()
        {
            string query_string = "update Accounts SET Password = '2' where Login = '1'";
            SQLServer.ExecuteQueryInsert_Update(query_string);

            query_string = "select * from Accounts where Login = '1' and Password = '2'";
            DataTable table = SQLServer.ExecuteQuerySelect(query_string);

            Assert.IsTrue(table.Rows.Count == 1);
        }
        readonly SqlConnection sqlConnection = new SqlConnection(DataBase.GetConnectionString());
        [TestMethod]
        public void CheckConnection()
        {
            DataBase db = new DataBase();
            db.ConnectionClose();
            Assert.IsTrue(sqlConnection.State == ConnectionState.Closed);
        }
        [TestMethod]
        public void ChecksRecordAddedToDatabase()
        {
            string query_string = "insert into Accounts (Login, Password, Name, Account_ID) VALUES ('A1s2f', " +
                        "'4g5Fa', 'TempGuest', 100001)";
            SQLServer.ExecuteQueryInsert_Update(query_string);

            query_string = "select * from Accounts where Login = 'A1s2f' and Password = '4g5Fa'";
            DataTable table = SQLServer.ExecuteQuerySelect(query_string);

            Assert.IsTrue(table.Rows.Count == 1);
        }

        [TestMethod]
        public void ChecksRecordRemovedToDatabase()
        {
            string query_string = "select * from Accounts where login = 'A1s2f' and password = '4g5Fa'";
            DataTable table = SQLServer.ExecuteQuerySelect(query_string);

            Assert.IsTrue(table.Rows.Count == 1);


            query_string = "delete from Accounts where login = 'A1s2f' and password = '4g5Fa'";
            SQLServer.ExecuteQueryDelete(query_string);

            query_string = "select * from Accounts where login = 'A1s2f' and password = '4g5Fa'";
            table = SQLServer.ExecuteQuerySelect(query_string);

            Assert.IsTrue(table.Rows.Count == 0);
        }
    }
}

﻿using Microsoft.Data.SqlClient;

namespace Tranning
{
    public class DatabaseConnection
    {
        public DatabaseConnection() { }

        public static SqlConnection GetSqlConnection()
        {
            string connectionString = "Server=CTINH\\DUNG;Database=Tranning;Trusted_Connection=True;TrustServerCertificate=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

    }
}

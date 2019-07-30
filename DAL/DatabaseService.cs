﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DatabaseService
    {
        public string stringConnection = @"Data Source=PEAGA;Initial Catalog=Database;Integrated Security=True";
        public SqlConnection connection;
        public SqlCommand command;
        public DatabaseService()
        {
            connection = new SqlConnection(stringConnection);

        }
        public void OpenConnection()
        {
            if (connection != null && connection.State == ConnectionState.Closed)
                connection.Open();
        }
        public void CloseConnection()
        {
            if (connection != null && connection.State == ConnectionState.Open)
                connection.Close();
        }
        public SqlDataReader ReadData(string sql, SqlParameter[] parameters)
        {
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = connection;
            OpenConnection();
            command.Parameters.AddRange(parameters);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        public bool WriteData(string sql, SqlParameter[] parameters)
        {
            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = connection;
            OpenConnection();
            command.Parameters.AddRange(parameters);
            int result = command.ExecuteNonQuery();
            return result > 0;
        }
    }
}
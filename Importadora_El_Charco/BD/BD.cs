using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD
{
    public abstract class BD
    {
        private string _connectionstring;
        protected SqlConnection _connection;

        public BD(string server, string db, string user, string password)
        {
            _connectionstring = $"Data Source={server}; Initial Catalog={db};" +
                $"User={user}; Password={password}";
        }
        public void connect()
        {
            _connection = new SqlConnection(_connectionstring);
            _connection.Open();
        }
        public void close()
        {
            if (_connection != null && _connection.State == System.Data.ConnectionState.Open)
                _connection.Close();
        }
    }
}

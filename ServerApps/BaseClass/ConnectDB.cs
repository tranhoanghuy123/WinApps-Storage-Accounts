using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApps.BaseClass
{
    public class ConnectDB
    {
        private string connectionString;
        private SqlDataAdapter adapter;
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;

        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public SqlDataAdapter Adapter { get => adapter; set => adapter = value; }
        public SqlConnection Connection { get => connection; set => connection = value; }
        public SqlCommand Command { get => command; set => command = value; }
        public SqlDataReader Reader { get => reader; set => reader = value; }

        public ConnectDB()
        {
            this.connectionString = null;
            this.connection = null;
            this.adapter = null; 
            this.command = null; 
            this.reader = null;
        }
        public ConnectDB(string connectionString, SqlDataAdapter adapter, SqlConnection connection, SqlCommand command, SqlDataReader reader)
        {
            this.connectionString = connectionString;
            this.adapter = adapter;
            this.connection = connection;
            this.command = command;
            this.reader = reader;
        }

        public bool Connect
    }
}

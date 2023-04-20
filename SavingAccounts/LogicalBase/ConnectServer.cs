using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RememberPassword.LogicBase
{
    public class ConnectServer
    {
        private string connectString;
        private SqlDataAdapter myReader;
        private SqlConnection myConn;
        private SqlCommand myCommand;

        public string ConnectString { get => connectString; set => connectString = value; }
        public SqlDataAdapter MyReader { get => myReader; set => myReader = value; }
        public SqlConnection MyConn { get => myConn; set => myConn = value; }
        public SqlCommand MyCommand { get => myCommand; set => myCommand = value; }

        public ConnectServer()
        {
        }
    }
}

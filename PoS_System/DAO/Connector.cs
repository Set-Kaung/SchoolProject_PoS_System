using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PoS_System.DAO
{
    class Connector
    {
        private string connString = "Server = 127.0.0.1;Port=3306;Database=pos_project;Uid=root;Pwd=Setkl24072001";
        private MySqlConnection connection;
        public Connector() 
        {
            if (connection == null) 
            {
                Connection = new MySqlConnection(connString);
            }
        }

        public MySqlConnection Connection { get => connection; set => connection = value; }
    }
}

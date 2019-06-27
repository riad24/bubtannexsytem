using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace BubtAnnexSystem2
{
    class CONNECT
    {
        private MySqlConnection connection = new MySqlConnection("Datasource=localhost;port=3306;Username=root;Password=root;Database=bubtannex");

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public void openConnection()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();

            }
        }
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();

            }
        }
    }
}

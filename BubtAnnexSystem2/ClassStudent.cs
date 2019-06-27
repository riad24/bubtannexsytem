using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace BubtAnnexSystem2
{
    class ClassStudent
    {
        CONNECT conn = new CONNECT();

        public DataTable getStudent()
        {
            MySqlCommand command = new MySqlCommand("SELECT name AS Name, rollid as 'Roll Id', dptname as Department,intek as Intek FROM `student`", conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;


        }
        public string insertStudent(string name, string rool, string dptname, string inteck)
        {
                MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand();

                String insertQuery = "INSERT INTO routine (name, rollid, dptname, intek) VALUES (@name,@rool,@dpt,@intk)";
                command.CommandText = insertQuery;
                command.Connection = conn.GetConnection();
                command.Connection.Open();

                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@rool", MySqlDbType.VarChar).Value = rool;
                command.Parameters.Add("@dpt", MySqlDbType.VarChar).Value = dptname;
                command.Parameters.Add("@intk", MySqlDbType.VarChar).Value = inteck;

                if (command.ExecuteNonQuery() == 1)
                {

                    conn.closeConnection();
                    return "ok";
                }
                else
                {
                    conn.closeConnection();
                    return "no";
                }

        }

    }
}

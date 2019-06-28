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
            MySqlCommand studentComm = new MySqlCommand("SELECT * FROM `student` where rollid=@id", conn.GetConnection());
            MySqlDataAdapter Studentadapter = new MySqlDataAdapter();
            studentComm.Parameters.AddWithValue("@id", rool);
            studentComm.Connection = conn.GetConnection();
            studentComm.Connection.Open();

            MySqlDataReader studentreader;
            studentreader = studentComm.ExecuteReader();
            int count = 0;
            string userRole = string.Empty;
            while (studentreader.Read())
            {
                count = count + 1;
                userRole = studentreader["rollid"].ToString();
            }
            if (count == 1)
            {
                conn.closeConnection();
                return "insert";
            }
            else
            {
                conn.closeConnection();
                MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand();
                String insertQuery = "INSERT INTO student (name, rollid, dptname, intek) VALUES (@name,@rool,@dpt,@intk)";
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

        public Boolean editStudent(string name, string rool, string dptname, string inteck)
        {
            MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand();

            String insertQuery = "UPDATE student SET name=@name, dptname=@dpt, intek=@intk WHERE rollid=@rool";
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
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }

        }

    }
}

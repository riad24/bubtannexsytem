using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace BubtAnnexSystem2
{
    class Classroutine
    {
        CONNECT conn = new CONNECT();
        public DataTable getRoutine()
        {
            MySqlCommand command = new MySqlCommand("SELECT day AS Day, time as Time, subjectcode as 'Subject Code',subjectname as 'Subject Name', room as Room FROM `routine`", conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;

        }
        public string insertRoutine(string day, string time, string subjectcode, string subjectname,string room)
        {
            MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand();

            String insertQuery = "INSERT INTO routine (day, time, subjectcode, subjectname,room) VALUES (@day,@time,@sc,@sn,@room)";
            command.CommandText = insertQuery;
            command.Connection = conn.GetConnection();
            command.Connection.Open();

            command.Parameters.Add("@day", MySqlDbType.VarChar).Value = day;
            command.Parameters.Add("@time", MySqlDbType.VarChar).Value = time;
            command.Parameters.Add("@sc", MySqlDbType.VarChar).Value = subjectcode;
            command.Parameters.Add("@sn", MySqlDbType.VarChar).Value = subjectname;
            command.Parameters.Add("@room", MySqlDbType.VarChar).Value = room;

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

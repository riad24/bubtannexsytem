using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace BubtAnnexSystem2
{
    class RoutineClass
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
    }
}

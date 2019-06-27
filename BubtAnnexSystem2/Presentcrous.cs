using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace BubtAnnexSystem2
{
    class Presentcrous
    {
        CONNECT conn = new CONNECT();

        public DataTable getPresentcroues()
        {
            MySqlCommand command = new MySqlCommand("SELECT coursecode AS 'Course Code', coursetitle as 'Course Title', credit as Credit,type as Type, grade as Grade,final as Final,mid as Mid,outof as 'Out Of 30' FROM `presentcourse` where userid=@id", conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            command.Parameters.AddWithValue("@id", LoginFrom.Userid);

            DataTable table = new DataTable();

            adapter.SelectCommand = command;

            adapter.Fill(table);
            return table;


        }

        public DataTable getAdminPresentcroues()
        {
            MySqlCommand command = new MySqlCommand("SELECT coursecode AS 'Course Code', coursetitle as 'Course Title', credit as Credit,type as Type, grade as Grade,final as Final,mid as Mid,outof as 'Out Of 30' FROM `presentcourse`", conn.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;

            adapter.Fill(table);
            return table;


        }


        public string insertPresentCourse(string coursetitle, string coursecode, string credit, string type, string grade, string final, string mid, string outof,string userid)
        {
            MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand();

            String insertQuery = "INSERT INTO presentcourse (coursetitle, coursecode, credit, type, grade, final, mid, outof,userid) VALUES (@ct,@cc,@cdt,@typ,@grd,@fnl,@mid,@out,@uid)";
            command.CommandText = insertQuery;
            command.Connection = conn.GetConnection();
            command.Connection.Open();

            command.Parameters.Add("@ct", MySqlDbType.VarChar).Value = coursetitle;
            command.Parameters.Add("@cc", MySqlDbType.VarChar).Value = coursecode;
            command.Parameters.Add("@cdt", MySqlDbType.VarChar).Value = credit;
            command.Parameters.Add("@typ", MySqlDbType.VarChar).Value = type;
            command.Parameters.Add("@grd", MySqlDbType.VarChar).Value = grade;
            command.Parameters.Add("@fnl", MySqlDbType.VarChar).Value = final;
            command.Parameters.Add("@mid", MySqlDbType.VarChar).Value = mid;
            command.Parameters.Add("@out", MySqlDbType.VarChar).Value = outof;
            command.Parameters.Add("@uid", MySqlDbType.VarChar).Value = userid;

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

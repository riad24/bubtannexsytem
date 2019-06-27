using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace BubtAnnexSystem2
{
    class Register
    {
        CONNECT conn = new CONNECT();
        public string insertRegister(string userid, string password, string IdSerialNo, string email, string phone)
        {
            MySqlCommand studentComm = new MySqlCommand("SELECT * FROM `student` where rollid=@id", conn.GetConnection());
            MySqlDataAdapter Studentadapter = new MySqlDataAdapter();
            studentComm.Parameters.AddWithValue("@id", userid);
            studentComm.Connection = conn.GetConnection();
            studentComm.Connection.Open();

            MySqlDataReader studentreader;
            studentreader = studentComm.ExecuteReader();
            int count = 0;
            string studentName = string.Empty;
            string userRole = string.Empty;
            while (studentreader.Read())
            {
                count = count + 1;
                studentName = studentreader["name"].ToString();
            }
            if (count == 1)
            {
                conn.closeConnection();
                MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand();
                String insertQuery = "INSERT INTO users (userid, password, IdSerialNo, email, phone) VALUES (@uid,@pa,@sid,@eml,@phn)";
                command.CommandText = insertQuery;
                command.Connection = conn.GetConnection();
                command.Connection.Open();
                command.Parameters.Add("@uid", MySqlDbType.VarChar).Value = userid;
                command.Parameters.Add("@pa", MySqlDbType.VarChar).Value = password;
                command.Parameters.Add("@sid", MySqlDbType.VarChar).Value = IdSerialNo;
                command.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
                command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
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
            else
            {
                conn.closeConnection();
                return "authorized";
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;



namespace BubtAnnexSystem2
{
    public partial class LoginFrom : Form
    {
        public LoginFrom()
        {
            InitializeComponent();
        }

        public static string Userid = "";
        public static string StudentName = "";

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            CONNECT conn = new CONNECT();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            String query = "SELECT * FROM `users` WHERE `userid`=@usn AND `password`=@pass";

            command.CommandText = query;
            command.Connection = conn.GetConnection();

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBoxYourid.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPassword.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            MySqlDataReader myReader;
            command.Connection.Open();
            myReader = command.ExecuteReader();
            int count = 0;
            string userRole = string.Empty;
            while (myReader.Read())
            {
                count = count + 1;
                userRole = myReader["userid"].ToString();
            }
            if (count == 1)
            {
                myReader.Close();
                MessageBox.Show("Login is successfully", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Hide();
                if (userRole == "1111")
                {
                    this.Hide();
                    AdminForm aform = new AdminForm();
                    aform.Show();
                }
                else
                {
                    MySqlCommand studentComm = new MySqlCommand("SELECT * FROM `student` where rollid=@id", conn.GetConnection());
                    MySqlDataAdapter Studentadapter = new MySqlDataAdapter();
                    studentComm.Parameters.AddWithValue("@id", userRole);

                    MySqlDataReader studentreader;
                    studentreader = studentComm.ExecuteReader();
                
                    string studentName = string.Empty;
                    while (studentreader.Read())
                    {
                        studentName = studentreader["name"].ToString();
                    }

                    Userid = userRole;
                    StudentName = studentName;
                    this.Hide();
                    HomeForm mform = new HomeForm();
                    mform.Show();
                }
           
            }
            else
            {
                if (textBoxYourid.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your ID to Login", "Empty Your ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBoxPassword.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password to Login", "Empty Your Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("This ID Or Password Doesn't Exists", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

           

        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm rform = new RegisterForm();
            rform.Show();
        }
    }
}

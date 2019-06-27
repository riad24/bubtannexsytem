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
    public partial class FormSummary : Form
    {
        public FormSummary()
        {
            InitializeComponent();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginFrom lform = new LoginFrom();
            lform.Show();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm hform = new HomeForm();
            hform.Show();
        }

        private void RoutineButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Routine rform = new Routine();
            rform.Show();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormSummary_Load(object sender, EventArgs e)
        {
            CONNECT conn = new CONNECT();
            MySqlCommand studentComm = new MySqlCommand("SELECT * FROM `student` where rollid=@id", conn.GetConnection());
            MySqlDataAdapter Studentadapter = new MySqlDataAdapter();
            studentComm.Parameters.AddWithValue("@id", LoginFrom.Userid);
            studentComm.Connection.Open();

            MySqlDataReader studentreader;
            studentreader = studentComm.ExecuteReader();

            string studentName = string.Empty;
            string roll = string.Empty;
            string intake = string.Empty;
            string email = string.Empty;

            while (studentreader.Read())
            {
                studentName = studentreader["name"].ToString();
                roll = studentreader["rollid"].ToString();
                intake = studentreader["intek"].ToString();
            }

            nameStudent.Text = studentName;
            idLabel.Text = roll;
            intakLabel.Text = intake;
            emailLabel.Text = email;

        }
    }
}

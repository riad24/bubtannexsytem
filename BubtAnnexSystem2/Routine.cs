using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubtAnnexSystem2
{
    public partial class Routine : Form
    {
        RoutineClass routine = new RoutineClass();
        public Routine()
        {
            InitializeComponent();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginFrom lform = new LoginFrom();
            lform.Show();
        }

        private void Routine_Load(object sender, EventArgs e)
        {
            dataGridViewRoutine.DataSource = routine.getRoutine();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm mform = new HomeForm();
            mform.Show();
        }

        private void Academicinfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Academicinfo mform = new Academicinfo();
            mform.Show();
        }
    }
}

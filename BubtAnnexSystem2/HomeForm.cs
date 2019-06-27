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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }


        private void GoAcademicinfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Academicinfo aform = new Academicinfo();
            aform.Show();
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginFrom lform = new LoginFrom();
            lform.Show();

        }

        private void Routine_Click(object sender, EventArgs e)
        {
            this.Hide();
            Routine rform = new Routine();
            rform.Show();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            labelUsername.Text = LoginFrom.StudentName;
        }

       
    }
}

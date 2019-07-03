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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginFrom lform = new LoginFrom();
            lform.Show();
        }

        private void ButtonStudent_Click(object sender, EventArgs e)
        {
            StudentForm sform = new StudentForm();
            sform.ShowDialog();
        }

        private void ButtonRoutine_Click(object sender, EventArgs e)
        {
            addRoutineForm rform = new addRoutineForm();
            rform.ShowDialog();
        }

        private void ButtonPresentCourse_Click(object sender, EventArgs e)
        {
            AddPresentCouriseForm pform = new AddPresentCouriseForm();
            pform.ShowDialog();
        }

        private void ButtonPreviousCourse_Click(object sender, EventArgs e)
        {
            AddPreviousCourseForm pvform = new AddPreviousCourseForm();
            pvform.ShowDialog();
        }

        private void ButtonAllCourse_Click(object sender, EventArgs e)
        {
            addAllCourseForm aform = new addAllCourseForm();
            aform.ShowDialog();
        }
    }
}

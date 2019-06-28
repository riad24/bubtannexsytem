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
    public partial class Academicinfo : Form
    {
        public Academicinfo()
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

        private void Presentcroues_Click(object sender, EventArgs e)
        {
            this.Hide();
            PresentCrouses hform = new PresentCrouses();
            hform.Show();
        }

        private void Previouscroues_Click(object sender, EventArgs e)
        {
            this.Hide();
            PreviouscrouesForm hform = new PreviouscrouesForm();
            hform.Show();
        }

        private void RoutineButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Routine rform = new Routine();
            rform.Show();
        }

        private void SummaryGo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSummary rform = new FormSummary();
            rform.Show();
        }
    }
}

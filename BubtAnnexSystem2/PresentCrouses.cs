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
    public partial class PresentCrouses : Form
    {
        Presentcrous presentcroues = new Presentcrous();

        public PresentCrouses()
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

        private void Academicinfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Academicinfo aform = new Academicinfo();
            aform.Show();
        }

        private void PresentCrouses_Load(object sender, EventArgs e)
        {
            dataGridViewPresent.DataSource = presentcroues.getPresentcroues();

        }
    }
}

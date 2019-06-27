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
    public partial class addRoutineForm : Form
    {
        Classroutine routine = new Classroutine();
        public addRoutineForm()
        {
            InitializeComponent();
        }

        private void RoutineAdd_Click(object sender, EventArgs e)
        {
            String time = textBoxTime.Text;
            String subjectname = Subjectname.Text;
            String subjcode = subjectCode.Text;
            String room = textRoom.Text;
            String day = ((KeyValuePair<string, string>)Dayselectbox.SelectedItem).Value.ToString();

            if (time.Trim().Equals("") || subjectname.Trim().Equals("") || subjcode.Trim().Equals("") || room.Trim().Equals("") || day.Trim().Equals(""))
            {
                MessageBox.Show("Required Fields - Day , TIme , Subject Name & Room", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String insertClient = routine.insertRoutine(day, time, subjcode, subjectname, room);

                if (insertClient == "ok")
                {
                    textBoxTime.Text = "";
                    Subjectname.Text = "";
                    subjectCode.Text = "";
                    textRoom.Text = "";
                    Dayselectbox.SelectedText = "";
                    routineGridviewLoad();


                    MessageBox.Show("New Student Inserted Successfuly", "Inserted Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (insertClient == "no")
                {
                    MessageBox.Show("Error-Student", "Add Inserted Student", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void AddRoutineForm_Load(object sender, EventArgs e)
        {
            dataGridViewRoutine.DataSource = routine.getRoutine();

            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            comboSource.Add("SATERDAY", "SATERDAY");
            comboSource.Add("SUNDAY", "SUNDAY");
            comboSource.Add("MONDAY", "MONDAY");
            comboSource.Add("TUSEDAY", "TUSEDAY");
            comboSource.Add("WEDNESDAY", "WEDNESDAY");
            comboSource.Add("Friday", "Friday");
            Dayselectbox.DataSource = new BindingSource(comboSource, null);
            Dayselectbox.DisplayMember = "Text";
            Dayselectbox.ValueMember = "Value";
        }

        public void routineGridviewLoad()
        {
            dataGridViewRoutine.DataSource = routine.getRoutine();
        }
    }
}

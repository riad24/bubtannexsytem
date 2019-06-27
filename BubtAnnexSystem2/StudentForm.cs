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
    public partial class StudentForm : Form
    {
        ClassStudent student = new ClassStudent();
        public StudentForm()
        {
            InitializeComponent();
        }
  
        private void StudentAdd_Click(object sender, EventArgs e)
        {
            String name = textBoxname.Text;
            String rool = textBoxroll.Text;
            String inteck = textBoxinteck.Text;
            String dpt = ((KeyValuePair<string, string>)dptselectbox.SelectedItem).Value.ToString();

            if (name.Trim().Equals("") || rool.Trim().Equals("") || dpt.Trim().Equals(""))
            {
                MessageBox.Show("Required Fields - Name , Roll & Department", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String insertClient = student.insertStudent(name, rool, dpt, inteck);

                if (insertClient == "ok")
                {
                    textBoxname.Text = "";
                    textBoxroll.Text = "";
                    textBoxinteck.Text = "";
                    dptselectbox.SelectedText = "";
                    studentGridviewLoad();


                    MessageBox.Show("New Student Inserted Successfuly", "Inserted Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (insertClient == "no")
                {
                    MessageBox.Show("Error-Student", "Add Inserted Student", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            dataGridViewStudent.DataSource = student.getStudent();

            Dictionary<string,string> comboSource = new Dictionary<string, string>();
            comboSource.Add("CSE", "CSE");
            comboSource.Add("EEE", "EEE");
            comboSource.Add("RAC", "RAC");
            dptselectbox.DataSource = new BindingSource(comboSource, null);
            dptselectbox.DisplayMember = "Text";
            dptselectbox.ValueMember = "Value";
        }

        public void studentGridviewLoad()
        {
            dataGridViewStudent.DataSource = student.getStudent();
        }
    }
}

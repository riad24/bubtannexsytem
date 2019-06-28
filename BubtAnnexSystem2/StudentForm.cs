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
                String insertStudent = student.insertStudent(name, rool, dpt, inteck);

                if (insertStudent == "ok")
                {
                    textBoxname.Text = "";
                    textBoxroll.Text = "";
                    textBoxinteck.Text = "";
                    dptselectbox.SelectedText = "";
                    studentGridviewLoad();


                    MessageBox.Show("New Student Inserted Successfuly", "Inserted Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (insertStudent == "no")
                {
                    MessageBox.Show("Error-Student", "Add Inserted Student", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }else if (insertStudent == "insert")
                {
                    MessageBox.Show("Student Roll ID Already Insert", "Add Inserted Student", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void DataGridViewStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxname.Text = dataGridViewStudent.CurrentRow.Cells[0].Value.ToString();
            textBoxroll.Text = dataGridViewStudent.CurrentRow.Cells[1].Value.ToString();
            dptselectbox.SelectedItem = dataGridViewStudent.CurrentRow.Cells[2].Value.ToString();
            textBoxinteck.Text = dataGridViewStudent.CurrentRow.Cells[3].Value.ToString();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            String name = textBoxname.Text;
            String rool = textBoxroll.Text;
            String inteck = textBoxinteck.Text;
            String dpt = ((KeyValuePair<string, string>)dptselectbox.SelectedItem).Value.ToString();

            

                try
            {
                if (name.Trim().Equals("") || rool.Trim().Equals("") || dpt.Trim().Equals(""))
                {
                    MessageBox.Show("Required Fields - Name , Roll & Department", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Boolean insertClient = student.editStudent(name, rool, dpt, inteck);

                    if (insertClient)
                    {
                        textBoxname.Text = "";
                        textBoxroll.Text = "";
                        textBoxinteck.Text = "";
                        dptselectbox.SelectedText = "";
                        dataGridViewStudent.DataSource = student.getStudent();
                        MessageBox.Show("Student Updated Successfuly", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ERROR - Student Not Updated", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}

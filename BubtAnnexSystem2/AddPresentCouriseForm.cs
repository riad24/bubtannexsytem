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
    public partial class AddPresentCouriseForm : Form
    {
        Presentcrous pcourse = new Presentcrous();

        public AddPresentCouriseForm()
        {
            InitializeComponent();
        }

        private void PresentCourseAdd_Click_1(object sender, EventArgs e)
        {
            String coursetitle = coursetitleBox.Text;
            String coursecode = coursecodeBox.Text;
            String credit = creditBox.Text;
            String grade = gradeBox.Text;
            String outof = outBox.Text;
            String mid = midBox.Text;
            String final = finalBox.Text;
            String type = typeBox.Text;
            String userid = useridBox.Text;

            if (coursetitle.Trim().Equals("") || coursecode.Trim().Equals(""))
            {
                MessageBox.Show("Required Fields - Course Title & Course Code", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String insertClient = pcourse.insertPresentCourse(coursetitle, coursecode, credit, type, grade, final, mid, outof, userid);

                if (insertClient == "ok")
                {
                    coursetitleBox.Text = "";
                    coursecodeBox.Text = "";
                    creditBox.Text = "";
                    typeBox.Text = "";
                    gradeBox.Text = "";
                    outBox.Text = "";
                    midBox.Text = "";
                    finalBox.Text = "";
                    prsentCourseGridviewLoad();


                    MessageBox.Show("New Present Course Inserted Successfuly", "Inserted Present Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (insertClient == "no")
                {
                    MessageBox.Show("Error-Present Course", "Add Inserted Present Course", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        public void prsentCourseGridviewLoad()
        {
            dataGridViewpresenCourse.DataSource = pcourse.getAdminPresentcroues();
        }

        private void AddPresentCouriseForm_Load_1(object sender, EventArgs e)
        {
            dataGridViewpresenCourse.DataSource = pcourse.getAdminPresentcroues();

        }
    }
}

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
    public partial class AddPreviousCourseForm : Form
    {
        Previouscrouse pvcourse = new Previouscrouse();

        public AddPreviousCourseForm()
        {
            InitializeComponent();
        }

        private void PreviouscourseAdd_Click(object sender, EventArgs e)
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

            if (userid.Trim().Equals("") || coursetitle.Trim().Equals("") || coursecode.Trim().Equals("") || credit.Trim().Equals(""))
            {
                MessageBox.Show("Required Fields - Course Title & Course Code", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String insertClient = pvcourse.insertPreviousCourse(coursetitle, coursecode, credit, type, grade, final, mid, outof, userid);
                if (insertClient == "ok")
                {
                    coursetitleBox.Text   = "";
                    coursecodeBox.Text    = "";
                    creditBox.Text        = "";
                    typeBox.Text          = "";
                    gradeBox.Text         = "";
                    outBox.Text           = "";
                    midBox.Text           = "";
                    finalBox.Text         = "";
                    useridBox.Text        = "";
                    previousCourseGridviewLoad();
                    MessageBox.Show("New Previous Course Inserted Successfuly", "Inserted Previous Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (insertClient == "no")
                {
                    MessageBox.Show("Error-Previous Course", "Add Inserted Previous Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddPreviousCourseForm_Load(object sender, EventArgs e)
        {
            dataGridViewpreviousCourse.DataSource = pvcourse.getAdminPrviouscroues();
        }

        public void previousCourseGridviewLoad()
        {
            dataGridViewpreviousCourse.DataSource = pvcourse.getAdminPrviouscroues();
        }
    }
}

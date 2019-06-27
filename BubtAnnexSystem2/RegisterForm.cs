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
    public partial class RegisterForm : Form
    {
        Register reg = new Register();
        public RegisterForm()
        {
            InitializeComponent();
        }


        private void LoginPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginFrom lform = new LoginFrom();
            lform.Show();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            String iuserid = userid.Text;
            String ipassword = password.Text;
            String iIdSerialNo = IdSerialNo.Text;
            String iemail = email.Text;
            String iphone = phone.Text;

            if (iuserid.Trim().Equals("") || ipassword.Trim().Equals("") || iIdSerialNo.Trim().Equals(""))
            {
                MessageBox.Show("Required Fields - Your ID + Password & iIdSerialNo", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String insertClient = reg.insertRegister(iuserid, ipassword, iIdSerialNo, iemail,iphone);

                if (insertClient == "ok")
                {
                    this.Hide();
                    LoginFrom lform = new LoginFrom();
                    lform.Show();
                    MessageBox.Show("New Register Inserted Successfuly", "Add Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(insertClient == "no")
                {
                    MessageBox.Show("Error-Register", "Add Register", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    userid.Text = "";
                    password.Text= "";
                    IdSerialNo.Text = "";
                    email.Text = "";
                    phone.Text = "";
                    MessageBox.Show("You are not Authorized Student", "Register Authorized", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Air_Express
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start form = new Start();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, surName, email, email2, password, password2, cellNum;
            name = txtName.Text;
            surName = txtSurName.Text;
            email = txtEmail.Text;
            email2 = txtEmail2.Text;
            password = txtPassword.Text;
            password2 = txtPassword2.Text;
            cellNum = txtCellNum.Text;
            SignUpClass objS = new SignUpClass(name,surName,email,email2,password,password2,cellNum);
           
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(surName) || String.IsNullOrEmpty(email) || String.IsNullOrEmpty(email2) || String.IsNullOrEmpty(password) || String.IsNullOrEmpty(password2))
            {
                MessageBox.Show(objS.SignUpNow());
            }
            else if (email != email2)
            {
                MessageBox.Show(objS.SignUpNow());
            }

            else if (password != password2)
            {
                MessageBox.Show(objS.SignUpNow());
            }
            else if (cellNum.Length != 10)
            {
                MessageBox.Show(objS.SignUpNow());
            }
            else
            {
                StreamWriter objSignUp = new StreamWriter(@"D:\School\Projects\1st Year\APDP101_Phase2_21\SignUpInfo.txt", true); //Replace With The Path of Your Textfile
                using (objSignUp)
                {
                    objSignUp.Write(objS.SignedUp());
                }
                MessageBox.Show("Sign Up Successful. \nIt is an honour to have join us here at AIR EXPRESS " + name + ' ' + surName + ".");

                this.Hide();
                Start form = new Start();
                form.Show();
            }

        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

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
    public partial class Sign_In : Form
    {
        public Sign_In()
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
            string lineRec = "";
            string[] lineArray = new string[5];
            string Email,Password;
            Email = txtEmail.Text;
            Password = txtPassword.Text;
            SignInFormClass objPFC = new SignInFormClass(Email, Password);

            StreamReader objSignIn = new StreamReader(@"D:\SignUpInfo.txt", true); //Replace With The Path of Your Textfile

            using (objSignIn)
            {
                lineRec = objSignIn.ReadLine();
                bool found = false;
                while (lineRec != null)
                {
                    lineArray = lineRec.Split('\t');
                    if (Email == (lineArray[2]) && Password == (lineArray[3]))
                    {
                        MessageBox.Show("Signed In Successfully");
                        found = true;
                        this.Hide();
                        Home form = new Home();
                        form.Show();
                        break;
                    }
                    lineRec = objSignIn.ReadLine();
                }

                if (!found)
                {
                    MessageBox.Show(objPFC.Details(),"Sign In");
                }
            }

            
        }

        private void Sign_In_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contact_us form = new Contact_us();
            form.Show();
        }

        private void chkShowHide_CheckedChanged(object sender, EventArgs e)
        {
            if(chkShowHide.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}

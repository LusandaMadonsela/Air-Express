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
    public partial class Contact_us : Form
    {
        public Contact_us()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Email, subject, message;
            Email = textBox2.Text;
            subject = textBox1.Text;
            message = textBox3.Text;
            Helpline objH = new Helpline(Email, subject, message);
           

            if ((Email == string.Empty) || (message == string.Empty) || (subject == string.Empty))
            {
                MessageBox.Show(objH.Sender());
            }
            else if ((Email == string.Empty) && (subject == string.Empty))
            {
                MessageBox.Show(objH.Sender());
            }
            else if ((subject == string.Empty) && (subject == string.Empty))
            {
                MessageBox.Show(objH.Sender());
            }
            else if ((Email == string.Empty) && (message == string.Empty))
            {
                MessageBox.Show(objH.Sender());
            }
            else
            {
                StreamWriter Writer = new StreamWriter(@"D:\School\Projects\1st Year\APDP101_Phase2_21\Contact_Us.txt", true); //Replace With The Path of Your Textfile


                using (Writer)
                {
                    Writer.WriteLine(objH.Display() + "\n");

                    MessageBox.Show("Your Message has been submitted and our consultants will get back to you shortly.\nThank you for choosing AIR EXPRESS.\n\nClick the 'Home Page' button to return to the Home page.");
                }

            }     
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start form = new Start();
            form.Show();
        }

        private void Contact_us_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

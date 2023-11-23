using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air_Express
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Offers form = new Offers();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to Log Out?", "Log Out", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                Start form = new Start();
                form.Show();

            }
            else if (dialog == DialogResult.No)
            {
                this.Show();
            }

            
        }

        private void closeLbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cancellation form = new Cancellation();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tickets form = new Tickets();
            form.Show();
        }


        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Contact_us form = new Contact_us();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Passenger form = new Passenger();
            form.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to Exit the app?", "Exit", MessageBoxButtons.YesNo);
            if(dialog==DialogResult.Yes)
            {
                Application.Exit();
            }
            else if(dialog==DialogResult.No)
            {
                this.Show();
            }
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

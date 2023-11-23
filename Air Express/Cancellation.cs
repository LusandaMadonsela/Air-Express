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
    public partial class Cancellation : Form
    {
        public Cancellation()
        {
            InitializeComponent();
        }

        private void btnCancelFlight_Click(object sender, EventArgs e)
        {
            string lineRec = "";
            string[] lineArray = new string[9];
            string flightcode, passengerID;
            flightcode = txtFCode.Text;
            passengerID = txtPassengerID.Text;
            CancellationsClass objC = new CancellationsClass(flightcode, passengerID);

            StreamReader IDnCodes = new StreamReader(@"D:\IDnCodes.txt", true); //Replace With The Path of Your Textfile



            using (IDnCodes)
            {
                lineRec = IDnCodes.ReadLine();
                bool found = false;
                while (lineRec != null)
                {
                    lineArray = lineRec.Split('\t');
                    if (passengerID==(lineArray[0])&&flightcode == (lineArray[4]))
                    {
                        lblName.Text = lineArray[1];
                        lblSurname.Text = lineArray[2];
                        lblDeparture.Text = lineArray[5];
                        lblDestination.Text = lineArray[6];
                        lblRefund.Text = lineArray[7] + " (Is to be credited to your account within 3 business days).";
                        MessageBox.Show($"The ticket for: \nflight Code: {flightcode} \nPassenger ID: {passengerID} \nhas been cancelled succesfully.\nCancellation details will be displayed below.");
                        found = true;
                        break;
                    }  
                    lineRec = IDnCodes.ReadLine(); 
                }
               

                if(!found)
                {
                    MessageBox.Show(objC.CancelNow());
                }    
            }



        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home form = new Home();
            form.Show();
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            clear();
        }
        void clear()
        {
            txtFCode.Clear();
            txtPassengerID.Clear();
            lblName.ResetText();
            lblSurname.ResetText();
            lblDeparture.ResetText();
            lblDestination.ResetText();
            lblRefund.ResetText();

        }

        private void Cancellation_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}

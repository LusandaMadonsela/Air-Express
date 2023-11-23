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
    public partial class frmFlight : Form
    {
        public frmFlight()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DateTime sdt = dtpDeparture.Value.Date;
            DateTime edt = dtpReturn.Value.Date;
            TimeSpan ts = edt - sdt;
            int days = ts.Days;
            lblNumDays.Text = days.ToString() + " Days";


            Random rnd = new Random();
            int flightcodes = rnd.Next(20000, 30000);
            flightcodes.ToString();


            string flightCompany, seatType, departure, destination,ReturnYN;
            int numSeats;
            double amtDue, SpecialDiscount, FinalAmount;
            flightCompany = cmbFlightCompany.Text;
            seatType = cmbSeatType.Text;
            departure = cmbDeparture.Text;
            destination = cmbDestination.Text;
            numSeats = int.Parse(cmbNumSeats.Text);

            if(radRoundTrip.Checked)
            {
                ReturnYN = "Yes - Round Trip";
            }
            else
            {
                ReturnYN = "No - One-Way";
            }


            if ((departure == destination) && ((radRoundTrip.Checked && sdt == edt) || (sdt>edt)))
            {
                lblNumDays.Text = "null";
                lblAmtDue.Text = "R0,00";
                lblSpecialDiscount.Text = "R0,00";
                lblFinalAmount.Text = "R0,00";
                lblFC.Text = "null";
                MessageBox.Show("Please enter unique 'Departure' and 'Destination' airports. \nPlease enter unique 'Departure' and 'Return' dates. \n\n(***Please also ensure that the'Departure Date' comes before the 'Return Date'.)");
            }
            else if (departure == destination)
            {
                lblNumDays.Text = "null";
                lblAmtDue.Text = "R0,00";
                lblSpecialDiscount.Text = "R0,00";
                lblFinalAmount.Text = "R0,00";
                lblFC.Text = "null";
                MessageBox.Show("Please enter unique 'Departure' and 'Destination' airports.");
            }
            else if (radRoundTrip.Checked && sdt == edt)
            {
                lblNumDays.Text = "null";
                lblAmtDue.Text = "R0,00";
                lblSpecialDiscount.Text = "R0,00";
                lblFinalAmount.Text = "R0,00";
                lblFC.Text = "null";
                MessageBox.Show("Please enter unique 'Departure' and 'Return' dates.");
            }
            else if(sdt>edt)
            {
                lblNumDays.Text = "null";
                lblAmtDue.Text = "R0,00";
                lblSpecialDiscount.Text = "R0,00";
                lblFinalAmount.Text = "R0,00";
                lblFC.Text = "null";
                MessageBox.Show("Please ensure that the'Departure Date' comes before the 'Return Date'.");
            }
            else
            {
                BookFlightClass objBF = new BookFlightClass(flightCompany, seatType, numSeats, departure, destination, days);
                amtDue = objBF.calcAmountDue();
                SpecialDiscount = objBF.calcSpecialDiscount();
                FinalAmount = objBF.calcFinalAmount();
                lblNumSeats.Text = numSeats.ToString();
                lblAmtDue.Text = amtDue.ToString("C");
                lblSpecialDiscount.Text = SpecialDiscount.ToString("C");
                lblFinalAmount.Text = FinalAmount.ToString("C");
                lblFC.Text = flightcodes.ToString();


                  StreamWriter objFC = new StreamWriter(@"D:\School\Projects\1st Year\APDP101_Phase2_21\BookFlight.txt", true); //Replace With The Path of Your Textfile


                using (objFC)
                {
                    objFC.Write(flightcodes + "\t");
                    objFC.Write(objBF.Locations()+"\t");
                    objFC.Write(ReturnYN + "\t");
                    objFC.Write(objBF.calcFinalAmount().ToString("C")+ "\n");
                    
                }

                StreamWriter objIDCodes = new StreamWriter(@"D:\School\Projects\1st Year\APDP101_Phase2_21\IDnCodes.txt", true);
                using (objIDCodes)
                {
                    objIDCodes.Write(flightcodes + "\t" + departure + "\t" + destination +"\t"+FinalAmount.ToString("C")+ "\t"+ReturnYN+"\n");
                }

                MessageBox.Show("Booking successful.\nThe amount due is: "+FinalAmount.ToString("C")+"\n\nYour Flight Code is: "+flightcodes+"\nPlease keep your Flight Code safe.\n\nClick the 'OK' to proceed to your payment.","Booking Status");
                amount = lblFinalAmount.Text;
                Payment form = new Payment();
                form.Show();
                this.Hide();
            }
        }

        public static string amount = "";
       

        private void frmFlight_Load(object sender, EventArgs e)
        {
            lblDeparture.Visible = false;
            lblReturn.Visible = false;
            dtpDeparture.Visible = false;
            dtpReturn.Visible = false;
        }

        private void radOneWay_CheckedChanged(object sender, EventArgs e)
        {
            lblDeparture.Visible = true;
            lblReturn.Visible = false;
            dtpDeparture.Visible = true;
            dtpReturn.Visible = false;
            lblNumDays.Visible = false;
            lblNum.Visible = false;
        }

        private void radRoundTrip_CheckedChanged(object sender, EventArgs e)
        {
            lblDeparture.Visible = true;
            lblReturn.Visible = true;
            dtpDeparture.Visible = true;
            dtpReturn.Visible = true;
            lblNumDays.Visible = true;
            lblNum.Visible = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("All your details will be lost and your flight will not get booked.\nAre you sure you want to go back to the Menu?", "Menu", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                List<string> lines = File.ReadAllLines(@"C:\Users\lusan\Desktop\APDP101_Phase2_21\IDnCodes.txt").ToList();
                File.WriteAllLines(@"C:\Users\lusan\Desktop\APDP101_Phase2_21\IDnCodes.txt", lines.GetRange(0, lines.Count - 1).ToArray());
                this.Hide();
                Home form = new Home();
                form.Show();
            }
            else if (dialog == DialogResult.No)
            {
                this.Show();
            }
        }

        private void frmFlight_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

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
    public partial class Passenger : Form
    {
        public Passenger()
        {
            InitializeComponent();      
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string passport, ID, name, surname, residency, gender, nationality, cellNum;
            passport = txtPassport.Text;
            ID = txtID.Text;
            name = txtName.Text;
            surname = txtSurname.Text;
            residency = txtResidency.Text;
            gender = cmbGender.Text;
            nationality = cmbNationality.Text;
            cellNum = txtCellNumber.Text;
            PassengerDetailsClass objPDC = new PassengerDetailsClass( passport, ID, name, surname, residency, gender, nationality, cellNum);
            

            if (String.IsNullOrEmpty(passport) || String.IsNullOrEmpty(ID) || String.IsNullOrEmpty(name) || String.IsNullOrEmpty(surname) || String.IsNullOrEmpty(residency) || String.IsNullOrEmpty(gender) || String.IsNullOrEmpty(nationality) || String.IsNullOrEmpty(cellNum))
            {
                MessageBox.Show(objPDC.PassengerReady());
            }
            else if (passport.StartsWith("A") == false && passport.Length != 9)
            {
                MessageBox.Show(objPDC.PassengerReady());
            }
            else if (ID.Length != 13)
            {
                MessageBox.Show(objPDC.PassengerReady());
            }
            else if (cellNum.Length != 10)
            {
                MessageBox.Show(objPDC.PassengerReady());
            }
            else
            {
                MessageBox.Show(objPDC.PassengerReady());

                StreamWriter objSP = new StreamWriter(@"D:\SavePassengerDetails.txt", true); //Replace With The Path of Your Textfile

                using (objSP)
                {
                    objSP.Write(objPDC.GetDisplay());
                }

                StreamWriter objIDCodes = new StreamWriter(@"D:\IDnCodes.txt", true); //Replace With The Path of Your Textfile
                using (objIDCodes)
                {
                    objIDCodes.Write(ID + "\t" + name + "\t" + surname + "\t" + cellNum + "\t");
                }

                this.Hide();
                frmFlight form = new frmFlight();
                form.Show();
            }         
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtPassport.ResetText();
            txtID.ResetText();
            txtName.ResetText();
            txtSurname.ResetText();
            txtResidency.ResetText();
            cmbGender.ResetText();
            cmbNationality.ResetText();
            txtCellNumber.ResetText();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("All your details will be lost.\nAre you sure you want to go back to the Menu?", "Menu", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                Home form = new Home();
                form.Show();
            }
            else if (dialog == DialogResult.No)
            {
                this.Show();
            }
            
        }

        private void Passenger_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}

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

    
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
            FinalAmount.Text = frmFlight.amount;

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CardName;
            string CardNum, Cvv, ExpY, ExpM;
            CardName = txtCardName.Text;
            CardNum = txtCardNum.Text;
            Cvv = txtCvv.Text;
            ExpY= txtExpY.Text;
            ExpM = txtExpM.Text;
            PaymentFormClass objPFC = new PaymentFormClass(CardName, CardNum, Cvv, ExpY, ExpM);


            if ((String.IsNullOrEmpty(CardNum)) && (String.IsNullOrEmpty(ExpM)) && (String.IsNullOrEmpty(CardName)) && (String.IsNullOrEmpty(ExpY)) && (String.IsNullOrEmpty(Cvv)))
            {
                MessageBox.Show(objPFC.PayNow());
            }
            else if (String.IsNullOrEmpty(CardNum))
            {
                MessageBox.Show(objPFC.PayNow());
            }

            else if (String.IsNullOrEmpty(ExpM))
            {
                MessageBox.Show(objPFC.PayNow());
            }

            else if (String.IsNullOrEmpty(CardName))
            {
                MessageBox.Show(objPFC.PayNow());
            }

            else if (String.IsNullOrEmpty(ExpY))
            {
                MessageBox.Show(objPFC.PayNow());
            }

            else if (String.IsNullOrEmpty(Cvv))
            {
                MessageBox.Show(objPFC.PayNow());
            }
            else if (CardNum.Length != 16)
            {
                MessageBox.Show(objPFC.PayNow());
            }

            else if (Cvv.Length != 3)
            {
                MessageBox.Show(objPFC.PayNow());
            }

            else
            {
                DialogResult dialog = MessageBox.Show("Payment was successful.\nWould you like to view your ticket now?.", "Payment", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    this.Hide();
                    Tickets form = new Tickets();
                    form.Show();
                }
                else if (dialog == DialogResult.No)
                {
                    this.Hide();
                    Home form = new Home();
                    form.Show();
                }
            }
           

        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("All your details will be lost and your flight will not get booked.\nAre you sure you want to go back to the Menu?", "Menu", MessageBoxButtons.YesNo);
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

        private void Payment_Load(object sender, EventArgs e)
        {
            PaymentFormClass m_myClass = new PaymentFormClass("Ash");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void Payment_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

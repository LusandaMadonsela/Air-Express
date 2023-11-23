using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Air_Express
{
    public class PaymentFormClass
    {
        private string CardName;
        private string CardNum, Cvv, ExpY, ExpM;

        public string propCardName
        {
            get { return CardName; }
            set { CardName = value; }
        }
        public string propCardNum
        {
            get { return CardNum; }
            set { CardNum = value; }
        }
        public string propCvv
        {
            get { return Cvv; }
            set { Cvv = value; }
        }
        public string propExpY
        {
            get { return ExpY; }
            set { ExpY = value; }
        }
        public string propExpM
        {
            get { return ExpM; }
            set { ExpM = value; }
        }

        public PaymentFormClass()
        {
            propCardName = "";
            propCardNum = "";
            propCvv = "";
            propExpY = "";
            propExpM = "";
            

        }

        public PaymentFormClass(string CN, string CNum, string Cvv, string EY, string EM)
        {
            propCardName = CN;
            propCardNum = CNum;
            propCvv = Cvv;
            propExpY = EY;
            propExpM = EM;
            
            

        }
        public string PayNow()
        {
            if((String.IsNullOrEmpty(CardNum))&& (String.IsNullOrEmpty(ExpM))&& (String.IsNullOrEmpty(CardName))&& (String.IsNullOrEmpty(ExpY))&& (String.IsNullOrEmpty(Cvv)))
            {
                return ("Please fill in all details to proceed.");
            }
            if (String.IsNullOrEmpty(CardNum))
            {
                return ("Please Fill In Card Number Correctly");
            }

            else if (String.IsNullOrEmpty(ExpM))
            {
                return ("Please Fill In Expiry Month");
            }

            else if (String.IsNullOrEmpty(CardName))
            {
                return ("Please Fill The Name The Card Belongs To");
            }

            else if (String.IsNullOrEmpty(ExpY))
            {
                return ("Please Fill In Expiry Year");
            }

            else if (String.IsNullOrEmpty(Cvv))
            {
                return ("Please Fill In CVV Number");
            }
            else if (CardNum.Length != 16)
            {
                return ("Card Number Does Not Exist, Check Amount Of Digits Entered");
            }
           
            else if (Cvv.Length != 3)
            {
                return ("CVV Number Must Be 3 Digits");
            }
            

            else
            {
                return ("Payment was successful.\nWould you like to view your ticket now?.");
            }
        }

        public string myMsg;

        public PaymentFormClass(string msg)
        {

            myMsg = msg;
            MessageBox.Show("You About To Proceed To Payment, I'm Glad Everything Met Your Expectations");

        }


    }
}

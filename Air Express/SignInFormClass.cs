using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air_Express
{
    public class SignInFormClass
    {
        private string Email;
        private string Password;

        public string propEmail
        {
            get { return Email; }
            set { Email = value; }
        }

        public string propPassword
        {
            get { return Password; }
            set { Password = value; }
        }

        public SignInFormClass()
        {
            propEmail = "";
            propPassword = "";

        }

        public SignInFormClass(string E, string P)
        {
            propEmail = E;
            propPassword = P;


        }

        public string Details()
        {
            if (String.IsNullOrEmpty(Email)&& String.IsNullOrEmpty(Password))
            {
                return ("Please fill in your details to proceed.");
            }

            else if (String.IsNullOrEmpty(Email))
            {
                return ("Please Enter Your Email Address");
            }
            else if (String.IsNullOrEmpty(Password))
            {
                return ("Please Enter Your Password");
            }

            else
            {
                return ("Please enter the correct sign in details.\n\nIf you forgot your details Click the 'Help' button to get in touch with one of our consultants for help");
            }
        }
    }
}

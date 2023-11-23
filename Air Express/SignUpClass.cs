using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air_Express
{
    public class SignUpClass
    {
        private string name, surName, email, email2, password, password2, cellNum;

        public string propName
        {
            get { return name; }
            set { name = value; }
        }
        public string propSurName
        {
            get { return surName; }
            set { surName = value; }
        }
        public string propEmail
        {
            get { return email; }
            set { email = value; }
        }
        public string propEmail2
        {
            get { return email2; }
            set { email2 = value; }
        }

        public string propPassword
        {
            get { return password; }
            set { password = value; }
        }
        public string propPassword2
        {
            get { return password2; }
            set { password2 = value; }
        }
        public string propCellNum
        {
            get { return cellNum; }
            set { cellNum = value; }
        }

        public SignUpClass()
        {
            propName = "";
            propSurName = "";
            propEmail = "";
            propEmail2 = "";
            propPassword = "";
            propPassword2 = "";
            propCellNum = "";

        }

        public SignUpClass(string N, string SN, string E, string E2, string P, string P2,string CN)
        {
            propName = N;
            propSurName = SN;
            propEmail = E;
            propEmail2 = E2;
            propPassword = P;
            propPassword2 = P2;
            propCellNum = CN;


        }

        public string SignUpNow()
        {
            if (String.IsNullOrEmpty(name)|| String.IsNullOrEmpty(surName)|| String.IsNullOrEmpty(email)|| String.IsNullOrEmpty(email2)|| String.IsNullOrEmpty(password)|| String.IsNullOrEmpty(password2))
            {
                return ("Please Ensure That You Fill Out All The Required Details");
            }
            else if (email!= email2)
            {
                return ("Email Do Not Match. Please Make Sure You Re-Enter The Correct Email.");
            }

            else if (password!= password2)
            {
                return ("Passwords Do Not Match. Please Make Sure You Re-Enter The Correct Password.");
            }
            else if(cellNum.Length!=10)
            {
                return("Cell Number Does Not Exist. Please Ensure That Your Cell Number Has 10 Digits.");
            }
            else
            {
                return ("Sign Up Successful. \nIt is an honour to have join us here at AIR EXPRESS " +name+' '+surName+".");
            }
        }

        public string SignedUp()
        {
            return (name+"\t"+surName+"\t"+email+"\t"+password+"\t"+cellNum+"\n");
        }
    }
   
}

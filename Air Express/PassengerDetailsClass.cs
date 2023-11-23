using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air_Express
{
    public class PassengerDetailsClass
    {
        private string passport,ID, name, surname, residency, gender, nationality, cellNum;


        public string propPassport
        {
            get { return passport; }
            set { passport= value; }
        }
        public string propID
        {
            get { return ID; }
            set { ID = value; }
        }

        public string propName
        {
            get { return name; }
            set { name = value; }
        }
        public string propSurName
        {
            get { return surname; }
            set { surname = value; }
        }
        public string propResidency
        {
            get { return residency; }
            set { residency = value; }
        }
        public string propGender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string propNationality
        {
            get { return nationality; }
            set { nationality = value; }
        }

        public string propCellNum
        {
            get { return cellNum; }
            set { cellNum = value; }
        }

        public PassengerDetailsClass()
        {
            propPassport = "";
            propID = "";
            propName = "";
            propSurName = "";
            propResidency = "";
            propGender = "";
            propNationality = "";
            propCellNum = "";

        }

        public PassengerDetailsClass(string P,string IDP, string N, string SN, string R, string G, string NT, string CN)
        {
            propPassport = P;
            propID = IDP;
            propName = N;
            propSurName = SN;
            propResidency = R;
            propGender = G;
            propNationality = NT;
            propCellNum = CN;
        }

        public string PassengerReady()
        {
            if (String.IsNullOrEmpty(passport)||String.IsNullOrEmpty(ID) || String.IsNullOrEmpty(name) || String.IsNullOrEmpty(surname) || String.IsNullOrEmpty(residency) || String.IsNullOrEmpty(gender) || String.IsNullOrEmpty(nationality) || String.IsNullOrEmpty(cellNum))
            {
                return ("Please Ensure That You Fill Out All The Required Details");
            }
            else if(passport.StartsWith("A")==false && passport.Length!=9)
            {
                return ("Passport format is incorrect.\nPlease re-enter your Passport Number.");
            }
            else if (ID.Length != 13)
            {
                return("ID Number Does Not Exist, Check Amount Of Digits Entered");
            }
            else if (cellNum.Length != 10)
            {
                return ("Cell Number Does Not Exist. Please Ensure That Your Cell Number Must be 10 Digits.");
            }
            else
            {
                return (name + " " + surname + " your details have been saved.\nClick 'OK' to proceed with your booking.");
            }
        }

        public string GetDisplay()
        {
            string msg = "";
            msg += ID + "\t";
            msg += name + "\t";
            msg += surname +"\t";
            msg += residency+"\t";
            msg += gender+"\t";
            msg += nationality+"\t";
            msg += cellNum + "\n";
            return msg;
        }
    }
}

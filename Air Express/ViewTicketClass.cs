using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air_Express
{
    public class ViewTicketClass
    {
        private string flightcode;
        private string passengerID;


        public string propFlightCode
        {
            get { return flightcode; }
            set { flightcode = value; }
        }

        public string propPassengerID
        {
            get { return passengerID; }
            set { passengerID = value; }
        }


        //Defualt Constructors

        public ViewTicketClass()
        {
            propFlightCode = "";
            propPassengerID = "";
        }

        //Constuctors

        public ViewTicketClass(string FC, string PI)
        {
            propFlightCode = FC;
            propPassengerID = PI;

        }

        public string ViewNow()
        {

            if ((String.IsNullOrEmpty(flightcode)) && (String.IsNullOrEmpty(passengerID)))
            {
                return ("Please Fill In The Flight Code Correctly.\nPlease Fill In The Passenger ID Correctly.");
            }
            else if (String.IsNullOrEmpty(flightcode))
            {
                return ("Please Fill In The Flight Code Correctly");
            }

            else if (String.IsNullOrEmpty(passengerID))
            {
                return ("Please Fill In Passenger ID");
            }
            else if ((flightcode.Length != 5) && (passengerID.Length != 13))
            {
                return ("Passenger ID Does Not Exist, Check Amount Of Digits Entered.\nFlight Code Does Not Exist.");
            }
            else if (flightcode.Length != 5)
            {
                return ("Flight Code Does Not Exist.");
            }
            else if (passengerID.Length != 13)
            {
                return ("Passenger ID Does Not Exist, Check Amount Of Digits Entered.");
            }

            else
            {
                return ("Ticket not found please enter the correct details.");
            }
        }
    }   
}

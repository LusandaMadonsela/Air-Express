using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air_Express
{
    public class Helpline
    {
        private string Email;
        private string subject;
        private string message;

        public string propEmail
        {
            get { return Email; }
            set { Email = value; }
        }

        public string propSubject
        {
            get { return subject; }
            set { subject = value; }
        }

        public string propMessage
        {
            get { return message; }
            set { message = value; }

        }

        public Helpline()
        {
            propEmail = "";
            propSubject = "";
            propMessage = "";
        }

        public Helpline(string E, string SUB, string MSG)
        {
            propEmail = E;
            propSubject = SUB;
            propMessage = MSG;

        }
        public string Display()
        {
            string DC ="Email From: " +Email;
            DC += "\n"+ "Subject : "+subject;
            DC += "\n"+ "Message:"+message;
            return DC;
        }
        public string Sender()
        {
            if ((Email == string.Empty) || (message == string.Empty) || (subject == string.Empty))
                return ("Unable To submit : Please fill in  All given spaces");
            else if ((Email == string.Empty) && (subject == string.Empty))
                return ("Unable To submit : Please fill in  All given spaces");
            else if ((subject == string.Empty) && (subject == string.Empty))
                return ("Unable To submit : Please fill in  All given spaces");
            else if ((Email == string.Empty) && (message == string.Empty))
                return ("Unable To submit : Please fill in  All given spaces");
            else
                return (Email.ToString() + ' ' + "your Message has been submitted.\nThank you for choosing AIR EXPRESS.\n\nClick the 'Home' button to return to the Home page.");
        }
    }
}

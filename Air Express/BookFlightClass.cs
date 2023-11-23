using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air_Express
{
    public class BookFlightClass
    {
        private string flightCompany, seatType, departure, destination;
        private int numSeats, days;

        public string propFlightCompany
        {
            get { return flightCompany; }
            set { flightCompany = value; }
        }
        public string propSeatType
        {
            get { return seatType; }
            set { seatType = value; }
        }
        public int propNumSeats
        {
            get { return numSeats; }
            set { numSeats = value; }
        }
        public string propDeparture
        {
            get { return departure; }
            set { departure = value; }
        }
        public string propDestination
        {
            get { return destination; }
            set { destination = value; }
        }

        public int propDays
        {
            get { return days; }
            set { days = value; }
        }



        public BookFlightClass()
        {
            propFlightCompany = "";
            propSeatType = "";
            propNumSeats = 0;
            propDeparture = "";
            propDestination = "";
            propDays = 0;

        }

        public BookFlightClass(string FC, string ST, int NS, string DEP, string DES, int D)
        {
            propFlightCompany = FC;
            propSeatType = ST;
            propNumSeats = NS;
            propDeparture = DEP;
            propDestination = DES;
            propDays = D;
        }
        public double calcAmountDue()
        {
            //ECONOMY ECONOMY ECONOMY ECONOMY MANGO MANGO MANGO MANGO


            if (flightCompany == "Mango" && seatType == "economy" && departure == "DUR - King Shaka International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 619));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "JHB - OR Tambo International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 619)); //DUR - JHB


            if (flightCompany == "Mango" && seatType == "economy" && departure == "DUR - King Shaka International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 2024));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "CPT - Cape Town International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 2024)); //DUR - CPT



            if (flightCompany == "Mango" && seatType == "economy" && departure == "DUR - King Shaka International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 1998));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "BFN -Bloemfontein Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 1998)); //DUR - BFN



            if (flightCompany == "Mango" && seatType == "economy" && departure == "DUR - King Shaka International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 1222));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "PLZ - Port Elizabeth Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 1222)); //DUR - PLZ



            if (flightCompany == "Mango" && seatType == "economy" && departure == "DUR - King Shaka International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 1680));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "PTG - Polokwane International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 1680));//DUR - PTG



            if (flightCompany == "Mango" && seatType == "economy" && departure == "DUR - King Shaka International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 1655));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 1655));//DUR - MQP



            if (flightCompany == "Mango" && seatType == "economy" && departure == "DUR - King Shaka International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 1870));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "KIM - Kimberly Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 1870));//DUR - KIM



            if (flightCompany == "Mango" && seatType == "economy" && departure == "DUR - King Shaka International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 1800));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "NTY - Pilanesberg International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 1800));//DUR - NTY

            //JHB

            if (flightCompany == "Mango" && seatType == "economy" && departure == "JHB - OR Tambo International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 832));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "CPT - Cape Town International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 832));//JHB - CPT


            if (flightCompany == "Mango" && seatType == "economy" && departure == "JHB - OR Tambo International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 1053));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "BFN -Bloemfontein Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 1053));//JHB - BFN


            if (flightCompany == "Mango" && seatType == "economy" && departure == "JHB - OR Tambo International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 1111));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "PLZ - Port Elizabeth Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 1111));//JHB - PLZ



            if (flightCompany == "Mango" && seatType == "economy" && departure == "JHB - OR Tambo International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 953));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "PTG - Polokwane International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 953));//JHB - PTG



            if (flightCompany == "Mango" && seatType == "economy" && departure == "JHB - OR Tambo International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 885));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 885));//JHB - MQP



            if (flightCompany == "Mango" && seatType == "economy" && departure == "JHB - OR Tambo International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 1231));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "KIM - Kimberly Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 1231));//JHB - KIM



            if (flightCompany == "Mango" && seatType == "economy" && departure == "JHB - OR Tambo International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 1610));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "NTY - Pilanesberg International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 1610));//JHB - NTY


            //CPT


            if (flightCompany == "Mango" && seatType == "economy" && departure == "CPT - Cape Town International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 1034));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "BFN -Bloemfontein Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 1034));//CPT - BFN



            if (flightCompany == "Mango" && seatType == "economy" && departure == "CPT - Cape Town International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 910));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "PLZ - Port Elizabeth Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 910));//CPT - PLZ



            if (flightCompany == "Mango" && seatType == "economy" && departure == "CPT - Cape Town International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 2475));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "PTG - Polokwane International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 2475));//CPT - PTG




            if (flightCompany == "Mango" && seatType == "economy" && departure == "CPT - Cape Town International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 1984));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 1984));//CPT - MQP




            if (flightCompany == "Mango" && seatType == "economy" && departure == "CPT - Cape Town International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 1935));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "KIM - Kimberly Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 1935));//CPT - KIM




            if (flightCompany == "Mango" && seatType == "economy" && departure == "CPT - Cape Town International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 2010));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "NTY - Pilanesberg International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 2010));//CPT - NTY


            //BFN

            if (flightCompany == "Mango" && seatType == "economy" && departure == "BFN -Bloemfontein Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 2260));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "PLZ - Port Elizabeth Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 2260));//BFN - PLZ


            if (flightCompany == "Mango" && seatType == "economy" && departure == "BFN -Bloemfontein Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 2295));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "PTG - Polokwane International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 2295));//BFN - PTG



            if (flightCompany == "Mango" && seatType == "economy" && departure == "BFN -Bloemfontein Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 2146));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 2146));//BFN - MQP



            if (flightCompany == "Mango" && seatType == "economy" && departure == "BFN -Bloemfontein Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 2389));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "KIM - Kimberly Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 2389));//BFN - KIM



            if (flightCompany == "Mango" && seatType == "economy" && departure == "BFN -Bloemfontein Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 1987));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "NTY - Pilanesberg International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 1987));//BFN - NTY


            //PLZ


            if (flightCompany == "Mango" && seatType == "economy" && departure == "PLZ - Port Elizabeth Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 2541));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "PTG - Polokwane International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 2541));//PLZ - PTG


            if (flightCompany == "Mango" && seatType == "economy" && departure == "PLZ - Port Elizabeth Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 2973));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 2973));//PLZ - MQP



            if (flightCompany == "Mango" && seatType == "economy" && departure == "PLZ - Port Elizabeth Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 2593));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "KIM - Kimberly Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 2593));//PLZ - KIM



            if (flightCompany == "Mango" && seatType == "economy" && departure == "PLZ - Port Elizabeth Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 2138));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "NTY - Pilanesberg International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 2138));//PLZ - NTY


            //PTG

            if (flightCompany == "Mango" && seatType == "economy" && departure == "PTG - Polokwane International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 2694));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 2694));//PTG - MQP

            if (flightCompany == "Mango" && seatType == "economy" && departure == "PTG - Polokwane International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 3555));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "KIM - Kimberly Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 3555));//PTG - KIM



            if (flightCompany == "Mango" && seatType == "economy" && departure == "PTG - Polokwane International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 2266));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "NTY - Pilanesberg International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 2266));//PTG - NTY

            //MQP

            if (flightCompany == "Mango" && seatType == "economy" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 2810));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "KIM - Kimberly Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 2810));//MQP - KIM

            if (flightCompany == "Mango" && seatType == "economy" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 3134));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "NTY - Pilanesberg International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 3134));//MQP - NTY

            //KIM


            if (flightCompany == "Mango" && seatType == "economy" && departure == "KIM - Kimberly Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 2911));

            if (flightCompany == "Mango" && seatType == "economy" && departure == "NTY - Pilanesberg International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 2911));//KIM - NTY

            //PREMIUM PREMIUM PREMIUM PREMIUM MANGO MANGO MANGO MANGO MANGO

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "DUR - King Shaka International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 3709));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "JHB - OR Tambo International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 3709)); //DUR - JHB


            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "DUR - King Shaka International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 2982));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "CPT - Cape Town International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 2982)); //DUR - CPT



            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "DUR - King Shaka International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 9314));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "BFN -Bloemfontein Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 9314)); //DUR - BFN



            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "DUR - King Shaka International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 4721));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "PLZ - Port Elizabeth Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 4721)); //DUR - PLZ



            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "DUR - King Shaka International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 10761));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "PTG - Polokwane International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 10761));//DUR - PTG



            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "DUR - King Shaka International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 10180));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 10180));//DUR - MQP



            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "DUR - King Shaka International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 10422));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "KIM - Kimberly Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 10422));//DUR - KIM



            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "DUR - King Shaka International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 12033));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "NTY - Pilanesberg International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 12033));//DUR - NTY

            //JHB

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "JHB - OR Tambo International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 3151));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "CPT - Cape Town International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 3151));//JHB - CPT


            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "JHB - OR Tambo International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 9142));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "BFN -Bloemfontein Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 9142));//JHB - BFN


            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "JHB - OR Tambo International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 3766));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "PLZ - Port Elizabeth Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 3766));//JHB - PLZ



            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "JHB - OR Tambo International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 3000));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "PTG - Polokwane International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 3000));//JHB - PTG



            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "JHB - OR Tambo International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 3200));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 3200));//JHB - MQP



            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "JHB - OR Tambo International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 10250));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "KIM - Kimberly Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 10250));//JHB - KIM



            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "JHB - OR Tambo International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 10070));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "NTY - Pilanesberg International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 10070));//JHB - NTY


            //CPT


            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "CPT - Cape Town International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 5338));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "BFN -Bloemfontein Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 5338));//CPT - BFN



            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "CPT - Cape Town International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 4184));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "PLZ - Port Elizabeth Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 4184));//CPT - PLZ



            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "CPT - Cape Town International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 8749));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "PTG - Polokwane International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 8749));//CPT - PTG




            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "CPT - Cape Town International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 5315));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 5315));//CPT - MQP




            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "CPT - Cape Town International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 4487));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "KIM - Kimberly Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 4487));//CPT - KIM




            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "CPT - Cape Town International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 4610));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "NTY - Pilanesberg International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 4610));//CPT - NTY


            //BFN

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "BFN -Bloemfontein Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 5231));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "PLZ - Port Elizabeth Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 5231));//BFN - PLZ


            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "BFN -Bloemfontein Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 5650));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "PTG - Polokwane International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 5650));//BFN - PTG



            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "BFN -Bloemfontein Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 6217));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 6217));//BFN - MQP



            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "BFN -Bloemfontein Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 6400));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "KIM - Kimberly Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 6400));//BFN - KIM



            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "BFN -Bloemfontein Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 6600));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "NTY - Pilanesberg International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 6600));//BFN - NTY


            //PLZ


            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "PLZ - Port Elizabeth Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 6227));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "PTG - Polokwane International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 6227));//PLZ - PTG


            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "PLZ - Port Elizabeth Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 6144));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 6144));//PLZ - MQP



            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "PLZ - Port Elizabeth Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 6159));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "KIM - Kimberly Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 6159));//PLZ - KIM



            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "PLZ - Port Elizabeth Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 7400));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "NTY - Pilanesberg International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 7400));//PLZ - NTY


            //PTG

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "PTG - Polokwane International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 5600));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 5600));//PTG - MQP

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "PTG - Polokwane International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 4860));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "KIM - Kimberly Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 4860));//PTG - KIM



            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "PTG - Polokwane International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 4980));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "NTY - Pilanesberg International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 4980));//PTG - NTY

            //MQP

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 5278));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "KIM - Kimberly Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 5278));//MQP - KIM

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 6460));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "NTY - Pilanesberg International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 6460));//MQP - NTY

            //KIM


            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "KIM - Kimberly Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 5627));

            if (flightCompany == "Mango" && seatType == "premium economy" && departure == "NTY - Pilanesberg International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 5627));//KIM - NTY


            //BUSINESS BUSINESS BUSINESS BUSINESS MANGO MANGO MANGO MANGO MANGO

            if (flightCompany == "Mango" && seatType == "Business" && departure == "DUR - King Shaka International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 8996));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "JHB - OR Tambo International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 8996)); //DUR - JHB


            if (flightCompany == "Mango" && seatType == "Business" && departure == "DUR - King Shaka International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 5003));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "CPT - Cape Town International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 5003)); //DUR - CPT



            if (flightCompany == "Mango" && seatType == "Business" && departure == "DUR - King Shaka International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 11988));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "BFN -Bloemfontein Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 11988)); //DUR - BFN



            if (flightCompany == "Mango" && seatType == "Business" && departure == "DUR - King Shaka International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 7470));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "PLZ - Port Elizabeth Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 7470)); //DUR - PLZ



            if (flightCompany == "Mango" && seatType == "Business" && departure == "DUR - King Shaka International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 13050));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "PTG - Polokwane International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 13050));//DUR - PTG



            if (flightCompany == "Mango" && seatType == "Business" && departure == "DUR - King Shaka International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 11175));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 11175));//DUR - MQP



            if (flightCompany == "Mango" && seatType == "Business" && departure == "DUR - King Shaka International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 11786));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "KIM - Kimberly Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 11786));//DUR - KIM



            if (flightCompany == "Mango" && seatType == "Business" && departure == "DUR - King Shaka International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 13433));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "NTY - Pilanesberg International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 13433));//DUR - NTY

            //JHB

            if (flightCompany == "Mango" && seatType == "Business" && departure == "JHB - OR Tambo International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 4275));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "CPT - Cape Town International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 4275));//JHB - CPT


            if (flightCompany == "Mango" && seatType == "Business" && departure == "JHB - OR Tambo International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 32244));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "BFN -Bloemfontein Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 32244));//JHB - BFN


            if (flightCompany == "Mango" && seatType == "Business" && departure == "JHB - OR Tambo International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 8513));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "PLZ - Port Elizabeth Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 8513));//JHB - PLZ



            if (flightCompany == "Mango" && seatType == "Business" && departure == "JHB - OR Tambo International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 4578));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "PTG - Polokwane International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 4578));//JHB - PTG



            if (flightCompany == "Mango" && seatType == "Business" && departure == "JHB - OR Tambo International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 32915));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 32915));//JHB - MQP



            if (flightCompany == "Mango" && seatType == "Business" && departure == "JHB - OR Tambo International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 14734));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "KIM - Kimberly Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 14734));//JHB - KIM



            if (flightCompany == "Mango" && seatType == "Business" && departure == "JHB - OR Tambo International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 12370));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "NTY - Pilanesberg International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 12370));//JHB - NTY


            //CPT


            if (flightCompany == "Mango" && seatType == "Business" && departure == "CPT - Cape Town International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 6950));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "BFN -Bloemfontein Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 6950));//CPT - BFN



            if (flightCompany == "Mango" && seatType == "Business" && departure == "CPT - Cape Town International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 7841));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "PLZ - Port Elizabeth Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 7841));//CPT - PLZ



            if (flightCompany == "Mango" && seatType == "Business" && departure == "CPT - Cape Town International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 10929));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "PTG - Polokwane International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 10929));//CPT - PTG




            if (flightCompany == "Mango" && seatType == "Business" && departure == "CPT - Cape Town International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 6619));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 6619));//CPT - MQP




            if (flightCompany == "Mango" && seatType == "Business" && departure == "CPT - Cape Town International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 6320));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "KIM - Kimberly Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 6320));//CPT - KIM




            if (flightCompany == "Mango" && seatType == "Business" && departure == "CPT - Cape Town International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 5810));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "NTY - Pilanesberg International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 5810));//CPT - NTY


            //BFN

            if (flightCompany == "Mango" && seatType == "Business" && departure == "BFN -Bloemfontein Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 9966));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "PLZ - Port Elizabeth Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 9966));//BFN - PLZ


            if (flightCompany == "Mango" && seatType == "Business" && departure == "BFN -Bloemfontein Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 76431));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "PTG - Polokwane International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 76431));//BFN - PTG



            if (flightCompany == "Mango" && seatType == "Business" && departure == "BFN -Bloemfontein Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 21548));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 21548));//BFN - MQP



            if (flightCompany == "Mango" && seatType == "Business" && departure == "BFN -Bloemfontein Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 20982));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "KIM - Kimberly Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 20982));//BFN - KIM



            if (flightCompany == "Mango" && seatType == "Business" && departure == "BFN -Bloemfontein Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 17600));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "NTY - Pilanesberg International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 17600));//BFN - NTY


            //PLZ


            if (flightCompany == "Mango" && seatType == "Business" && departure == "PLZ - Port Elizabeth Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 10229));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "PTG - Polokwane International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 10229));//PLZ - PTG


            if (flightCompany == "Mango" && seatType == "Business" && departure == "PLZ - Port Elizabeth Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 10669));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 10669));//PLZ - MQP



            if (flightCompany == "Mango" && seatType == "Business" && departure == "PLZ - Port Elizabeth Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 10019));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "KIM - Kimberly Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 10019));//PLZ - KIM



            if (flightCompany == "Mango" && seatType == "Business" && departure == "PLZ - Port Elizabeth Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 12080));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "NTY - Pilanesberg International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 12080));//PLZ - NTY


            //PTG

            if (flightCompany == "Mango" && seatType == "Business" && departure == "PTG - Polokwane International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 51751));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 51751));//PTG - MQP

            if (flightCompany == "Mango" && seatType == "Business" && departure == "PTG - Polokwane International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 20899));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "KIM - Kimberly Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 20899));//PTG - KIM



            if (flightCompany == "Mango" && seatType == "Business" && departure == "PTG - Polokwane International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 11780));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "NTY - Pilanesberg International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 11780));//PTG - NTY

            //MQP

            if (flightCompany == "Mango" && seatType == "Business" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 21133));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "KIM - Kimberly Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 21133));//MQP - KIM

            if (flightCompany == "Mango" && seatType == "Business" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 16520));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "NTY - Pilanesberg International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 16520));//MQP - NTY

            //KIM


            if (flightCompany == "Mango" && seatType == "Business" && departure == "KIM - Kimberly Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 10807));

            if (flightCompany == "Mango" && seatType == "Business" && departure == "NTY - Pilanesberg International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 10807));//KIM - NTY

            //FIRST FIRST FIRST FIRST MANGO MANGO MANGO MANGO

            if (flightCompany == "Mango" && seatType == "First" && departure == "DUR - King Shaka International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 58967));

            if (flightCompany == "Mango" && seatType == "First" && departure == "JHB - OR Tambo International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 58967)); //DUR - JHB


            if (flightCompany == "Mango" && seatType == "First" && departure == "DUR - King Shaka International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 97772));

            if (flightCompany == "Mango" && seatType == "First" && departure == "CPT - Cape Town International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 97772)); //DUR - CPT



            if (flightCompany == "Mango" && seatType == "First" && departure == "DUR - King Shaka International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 61385));

            if (flightCompany == "Mango" && seatType == "First" && departure == "BFN -Bloemfontein Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 61385)); //DUR - BFN



            if (flightCompany == "Mango" && seatType == "First" && departure == "DUR - King Shaka International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 97889));

            if (flightCompany == "Mango" && seatType == "First" && departure == "PLZ - Port Elizabeth Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 97889)); //DUR - PLZ



            if (flightCompany == "Mango" && seatType == "First" && departure == "DUR - King Shaka International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 56821));

            if (flightCompany == "Mango" && seatType == "First" && departure == "PTG - Polokwane International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 56821));//DUR - PTG



            if (flightCompany == "Mango" && seatType == "First" && departure == "DUR - King Shaka International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 56330));

            if (flightCompany == "Mango" && seatType == "First" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 56330));//DUR - MQP



            if (flightCompany == "Mango" && seatType == "First" && departure == "DUR - King Shaka International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 100436));

            if (flightCompany == "Mango" && seatType == "First" && departure == "KIM - Kimberly Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 100436));//DUR - KIM



            if (flightCompany == "Mango" && seatType == "First" && departure == "DUR - King Shaka International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 98751));

            if (flightCompany == "Mango" && seatType == "First" && departure == "NTY - Pilanesberg International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 98751));//DUR - NTY

            //JHB

            if (flightCompany == "Mango" && seatType == "First" && departure == "JHB - OR Tambo International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 112180));

            if (flightCompany == "Mango" && seatType == "First" && departure == "CPT - Cape Town International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 112180));//JHB - CPT


            if (flightCompany == "Mango" && seatType == "First" && departure == "JHB - OR Tambo International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 79074));

            if (flightCompany == "Mango" && seatType == "First" && departure == "BFN -Bloemfontein Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 79074));//JHB - BFN


            if (flightCompany == "Mango" && seatType == "First" && departure == "JHB - OR Tambo International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 114318));

            if (flightCompany == "Mango" && seatType == "First" && departure == "PLZ - Port Elizabeth Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 114318));//JHB - PLZ



            if (flightCompany == "Mango" && seatType == "First" && departure == "JHB - OR Tambo International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 78457));

            if (flightCompany == "Mango" && seatType == "First" && departure == "PTG - Polokwane International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 78557));//JHB - PTG



            if (flightCompany == "Mango" && seatType == "First" && departure == "JHB - OR Tambo International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 84800));

            if (flightCompany == "Mango" && seatType == "First" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 84800));//JHB - MQP



            if (flightCompany == "Mango" && seatType == "First" && departure == "JHB - OR Tambo International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 79772));

            if (flightCompany == "Mango" && seatType == "First" && departure == "KIM - Kimberly Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 79772));//JHB - KIM



            if (flightCompany == "Mango" && seatType == "First" && departure == "JHB - OR Tambo International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 81448));

            if (flightCompany == "Mango" && seatType == "First" && departure == "NTY - Pilanesberg International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 81448));//JHB - NTY


            //CPT


            if (flightCompany == "Mango" && seatType == "First" && departure == "CPT - Cape Town International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 73824));

            if (flightCompany == "Mango" && seatType == "First" && departure == "BFN -Bloemfontein Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 73824));//CPT - BFN



            if (flightCompany == "Mango" && seatType == "First" && departure == "CPT - Cape Town International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 99503));

            if (flightCompany == "Mango" && seatType == "First" && departure == "PLZ - Port Elizabeth Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 99503));//CPT - PLZ



            if (flightCompany == "Mango" && seatType == "First" && departure == "CPT - Cape Town International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 124279));

            if (flightCompany == "Mango" && seatType == "First" && departure == "PTG - Polokwane International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 124279));//CPT - PTG




            if (flightCompany == "Mango" && seatType == "First" && departure == "CPT - Cape Town International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 74357));

            if (flightCompany == "Mango" && seatType == "First" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 74357));//CPT - MQP




            if (flightCompany == "Mango" && seatType == "First" && departure == "CPT - Cape Town International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 124198));

            if (flightCompany == "Mango" && seatType == "First" && departure == "KIM - Kimberly Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 124198));//CPT - KIM




            if (flightCompany == "Mango" && seatType == "First" && departure == "CPT - Cape Town International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 124449));

            if (flightCompany == "Mango" && seatType == "First" && departure == "NTY - Pilanesberg International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 124449));//CPT - NTY


            //BFN

            if (flightCompany == "Mango" && seatType == "First" && departure == "BFN -Bloemfontein Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 135885));

            if (flightCompany == "Mango" && seatType == "First" && departure == "PLZ - Port Elizabeth Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 135885));//BFN - PLZ


            if (flightCompany == "Mango" && seatType == "First" && departure == "BFN -Bloemfontein Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 136112));

            if (flightCompany == "Mango" && seatType == "First" && departure == "PTG - Polokwane International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 136112));//BFN - PTG



            if (flightCompany == "Mango" && seatType == "First" && departure == "BFN -Bloemfontein Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 136540));

            if (flightCompany == "Mango" && seatType == "First" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 136540));//BFN - MQP



            if (flightCompany == "Mango" && seatType == "First" && departure == "BFN -Bloemfontein Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 135414));

            if (flightCompany == "Mango" && seatType == "First" && departure == "KIM - Kimberly Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 135414));//BFN - KIM



            if (flightCompany == "Mango" && seatType == "First" && departure == "BFN -Bloemfontein Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 136029));

            if (flightCompany == "Mango" && seatType == "First" && departure == "NTY - Pilanesberg International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 136029));//BFN - NTY


            //PLZ


            if (flightCompany == "Mango" && seatType == "First" && departure == "PLZ - Port Elizabeth Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 124095));

            if (flightCompany == "Mango" && seatType == "First" && departure == "PTG - Polokwane International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 124095));//PLZ - PTG


            if (flightCompany == "Mango" && seatType == "First" && departure == "PLZ - Port Elizabeth Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 123767));

            if (flightCompany == "Mango" && seatType == "First" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 123767));//PLZ - MQP



            if (flightCompany == "Mango" && seatType == "First" && departure == "PLZ - Port Elizabeth Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 124014));

            if (flightCompany == "Mango" && seatType == "First" && departure == "KIM - Kimberly Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 124014));//PLZ - KIM



            if (flightCompany == "Mango" && seatType == "First" && departure == "PLZ - Port Elizabeth Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 134791));

            if (flightCompany == "Mango" && seatType == "First" && departure == "NTY - Pilanesberg International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 134791));//PLZ - NTY


            //PTG

            if (flightCompany == "Mango" && seatType == "First" && departure == "PTG - Polokwane International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 135917));

            if (flightCompany == "Mango" && seatType == "First" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 135917));//PTG - MQP

            if (flightCompany == "Mango" && seatType == "First" && departure == "PTG - Polokwane International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 124265));

            if (flightCompany == "Mango" && seatType == "First" && departure == "KIM - Kimberly Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 124265));//PTG - KIM



            if (flightCompany == "Mango" && seatType == "First" && departure == "PTG - Polokwane International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 134791));

            if (flightCompany == "Mango" && seatType == "First" && departure == "NTY - Pilanesberg International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 134791));//PTG - NTY

            //MQP

            if (flightCompany == "Mango" && seatType == "First" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 138617));

            if (flightCompany == "Mango" && seatType == "First" && departure == "KIM - Kimberly Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 138617));//MQP - KIM

            if (flightCompany == "Mango" && seatType == "First" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 139232));

            if (flightCompany == "Mango" && seatType == "First" && departure == "NTY - Pilanesberg International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 139232));//MQP - NTY

            //KIM


            if (flightCompany == "Mango" && seatType == "First" && departure == "KIM - Kimberly Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 136812));

            if (flightCompany == "Mango" && seatType == "First" && departure == "NTY - Pilanesberg International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 136812));//KIM - NTY



            //ECONOMY ECONOMY ECONOMY ECONOMY KULULA KULULA KULULA KULULA

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "DUR - King Shaka International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 824));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "JHB - OR Tambo International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 824)); //DUR - JHB


            if (flightCompany == "Kulula" && seatType == "economy" && departure == "DUR - King Shaka International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 2209));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "CPT - Cape Town International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 2209)); //DUR - CPT



            if (flightCompany == "Kulula" && seatType == "economy" && departure == "DUR - King Shaka International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 2278));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "BFN -Bloemfontein Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 2278)); //DUR - BFN



            if (flightCompany == "Kulula" && seatType == "economy" && departure == "DUR - King Shaka International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 1321));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "PLZ - Port Elizabeth Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 1321)); //DUR - PLZ



            if (flightCompany == "Kulula" && seatType == "economy" && departure == "DUR - King Shaka International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 2206));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "PTG - Polokwane International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 2206));//DUR - PTG



            if (flightCompany == "Kulula" && seatType == "economy" && departure == "DUR - King Shaka International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 1746));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 1746));//DUR - MQP



            if (flightCompany == "Kulula" && seatType == "economy" && departure == "DUR - King Shaka International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 1996));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "KIM - Kimberly Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 1996));//DUR - KIM



            if (flightCompany == "Kulula" && seatType == "economy" && departure == "DUR - King Shaka International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 1800));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "NTY - Pilanesberg International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 1800));//DUR - NTY

            //JHB

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "JHB - OR Tambo International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 920));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "CPT - Cape Town International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 920));//JHB - CPT


            if (flightCompany == "Kulula" && seatType == "economy" && departure == "JHB - OR Tambo International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 1162));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "BFN -Bloemfontein Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 1162));//JHB - BFN


            if (flightCompany == "Kulula" && seatType == "economy" && departure == "JHB - OR Tambo International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 1111));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "PLZ - Port Elizabeth Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 1111));//JHB - PLZ



            if (flightCompany == "Kulula" && seatType == "economy" && departure == "JHB - OR Tambo International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 953));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "PTG - Polokwane International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 953));//JHB - PTG



            if (flightCompany == "Kulula" && seatType == "economy" && departure == "JHB - OR Tambo International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 985));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 985));//JHB - MQP



            if (flightCompany == "Kulula" && seatType == "economy" && departure == "JHB - OR Tambo International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 1365));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "KIM - Kimberly Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 1365));//JHB - KIM



            if (flightCompany == "Kulula" && seatType == "economy" && departure == "JHB - OR Tambo International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 1513));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "NTY - Pilanesberg International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 1513));//JHB - NTY


            //CPT


            if (flightCompany == "Kulula" && seatType == "economy" && departure == "CPT - Cape Town International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 1034));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "BFN -Bloemfontein Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 1034));//CPT - BFN



            if (flightCompany == "Kulula" && seatType == "economy" && departure == "CPT - Cape Town International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 1032));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "PLZ - Port Elizabeth Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 1032));//CPT - PLZ



            if (flightCompany == "Kulula" && seatType == "economy" && departure == "CPT - Cape Town International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 2775));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "PTG - Polokwane International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 2775));//CPT - PTG




            if (flightCompany == "Kulula" && seatType == "economy" && departure == "CPT - Cape Town International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 2084));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 2084));//CPT - MQP




            if (flightCompany == "Kulula" && seatType == "economy" && departure == "CPT - Cape Town International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 1935));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "KIM - Kimberly Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 1935));//CPT - KIM




            if (flightCompany == "Kulula" && seatType == "economy" && departure == "CPT - Cape Town International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 2130));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "NTY - Pilanesberg International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 2130));//CPT - NTY


            //BFN

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "BFN -Bloemfontein Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 2450));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "PLZ - Port Elizabeth Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 2450));//BFN - PLZ


            if (flightCompany == "Kulula" && seatType == "economy" && departure == "BFN -Bloemfontein Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 2675));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "PTG - Polokwane International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 2675));//BFN - PTG



            if (flightCompany == "Kulula" && seatType == "economy" && departure == "BFN -Bloemfontein Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 2446));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 2446));//BFN - MQP



            if (flightCompany == "Kulula" && seatType == "economy" && departure == "BFN -Bloemfontein Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 2580));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "KIM - Kimberly Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 2580));//BFN - KIM



            if (flightCompany == "Kulula" && seatType == "economy" && departure == "BFN -Bloemfontein Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 2207));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "NTY - Pilanesberg International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 2207));//BFN - NTY


            //PLZ


            if (flightCompany == "Kulula" && seatType == "economy" && departure == "PLZ - Port Elizabeth Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 2581));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "PTG - Polokwane International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 2581));//PLZ - PTG


            if (flightCompany == "Kulula" && seatType == "economy" && departure == "PLZ - Port Elizabeth Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 3304));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 3304));//PLZ - MQP



            if (flightCompany == "Kulula" && seatType == "economy" && departure == "PLZ - Port Elizabeth Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 2782));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "KIM - Kimberly Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 2782));//PLZ - KIM



            if (flightCompany == "Kulula" && seatType == "economy" && departure == "PLZ - Port Elizabeth Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 2238));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "NTY - Pilanesberg International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 2238));//PLZ - NTY


            //PTG

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "PTG - Polokwane International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 2794));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 2794));//PTG - MQP

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "PTG - Polokwane International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 3865));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "KIM - Kimberly Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 3865));//PTG - KIM



            if (flightCompany == "Kulula" && seatType == "economy" && departure == "PTG - Polokwane International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 2786));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "NTY - Pilanesberg International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 2786));//PTG - NTY

            //MQP

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 3010));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "KIM - Kimberly Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 3010));//MQP - KIM

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 3434));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "NTY - Pilanesberg International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 3434));//MQP - NTY

            //KIM


            if (flightCompany == "Kulula" && seatType == "economy" && departure == "KIM - Kimberly Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 3088));

            if (flightCompany == "Kulula" && seatType == "economy" && departure == "NTY - Pilanesberg International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 3088));//KIM - NTY

            //PREMIUM PREMIUM PREMIUM PREMIUM KULULA KULULA KULULA KULULA

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "DUR - King Shaka International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 4078));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "JHB - OR Tambo International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 4078)); //DUR - JHB


            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "DUR - King Shaka International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 4295));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "CPT - Cape Town International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 4295)); //DUR - CPT



            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "DUR - King Shaka International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 9548));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "BFN -Bloemfontein Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 9548)); //DUR - BFN



            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "DUR - King Shaka International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 4908));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "PLZ - Port Elizabeth Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 4908)); //DUR - PLZ



            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "DUR - King Shaka International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 11339));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "PTG - Polokwane International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 11339));//DUR - PTG



            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "DUR - King Shaka International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 10438));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 10438));//DUR - MQP



            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "DUR - King Shaka International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 11402));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "KIM - Kimberly Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 11402));//DUR - KIM



            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "DUR - King Shaka International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 12033));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "NTY - Pilanesberg International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 12033));//DUR - NTY

            //JHB

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "JHB - OR Tambo International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 3619));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "CPT - Cape Town International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 3619));//JHB - CPT


            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "JHB - OR Tambo International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 9996));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "BFN -Bloemfontein Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 9996));//JHB - BFN


            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "JHB - OR Tambo International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 4312));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "PLZ - Port Elizabeth Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 4312));//JHB - PLZ



            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "JHB - OR Tambo International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 3228));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "PTG - Polokwane International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 3228));//JHB - PTG



            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "JHB - OR Tambo International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 3437));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 3437));//JHB - MQP



            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "JHB - OR Tambo International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 10632));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "KIM - Kimberly Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 10632));//JHB - KIM



            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "JHB - OR Tambo International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 10280));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "NTY - Pilanesberg International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 10280));//JHB - NTY


            //CPT


            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "CPT - Cape Town International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 5496));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "BFN -Bloemfontein Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 5496));//CPT - BFN



            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "CPT - Cape Town International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 4254));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "PLZ - Port Elizabeth Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 4254));//CPT - PLZ



            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "CPT - Cape Town International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 8886));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "PTG - Polokwane International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 8886));//CPT - PTG




            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "CPT - Cape Town International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 5512));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 5512));//CPT - MQP




            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "CPT - Cape Town International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 4488));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "KIM - Kimberly Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 4488));//CPT - KIM




            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "CPT - Cape Town International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 4812));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "NTY - Pilanesberg International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 4812));//CPT - NTY


            //BFN

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "BFN -Bloemfontein Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 5430));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "PLZ - Port Elizabeth Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 5430));//BFN - PLZ


            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "BFN -Bloemfontein Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 5810));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "PTG - Polokwane International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 5810));//BFN - PTG



            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "BFN -Bloemfontein Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 6358));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 6358));//BFN - MQP



            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "BFN -Bloemfontein Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 6570));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "KIM - Kimberly Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 6570));//BFN - KIM



            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "BFN -Bloemfontein Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 6600));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "NTY - Pilanesberg International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 6600));//BFN - NTY


            //PLZ


            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "PLZ - Port Elizabeth Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 6327));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "PTG - Polokwane International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 6327));//PLZ - PTG


            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "PLZ - Port Elizabeth Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 6354));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 6354));//PLZ - MQP



            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "PLZ - Port Elizabeth Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 6217));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "KIM - Kimberly Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 6217));//PLZ - KIM



            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "PLZ - Port Elizabeth Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 7469));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "NTY - Pilanesberg International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 7469));//PLZ - NTY


            //PTG

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "PTG - Polokwane International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 5740));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 5740));//PTG - MQP

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "PTG - Polokwane International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 5067));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "KIM - Kimberly Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 5067));//PTG - KIM



            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "PTG - Polokwane International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 4995));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "NTY - Pilanesberg International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 4995));//PTG - NTY

            //MQP

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 5378));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "KIM - Kimberly Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 5378));//MQP - KIM

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 6640));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "NTY - Pilanesberg International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 6640));//MQP - NTY

            //KIM


            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "KIM - Kimberly Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 5832));

            if (flightCompany == "Kulula" && seatType == "premium economy" && departure == "NTY - Pilanesberg International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 5832));//KIM - NTY


            //BUSINESS BUSINESS BUSINESS BUSINESS KULULA KULULA KULULA KULULA


            if (flightCompany == "Kulula" && seatType == "Business" && departure == "DUR - King Shaka International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 9732));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "JHB - OR Tambo International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 9732)); //DUR - JHB


            if (flightCompany == "Kulula" && seatType == "Business" && departure == "DUR - King Shaka International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 6403));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "CPT - Cape Town International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 6403)); //DUR - CPT



            if (flightCompany == "Kulula" && seatType == "Business" && departure == "DUR - King Shaka International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 12381));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "BFN -Bloemfontein Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 12381)); //DUR - BFN



            if (flightCompany == "Kulula" && seatType == "Business" && departure == "DUR - King Shaka International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 7982));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "PLZ - Port Elizabeth Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 7982)); //DUR - PLZ



            if (flightCompany == "Kulula" && seatType == "Business" && departure == "DUR - King Shaka International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 12780));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "PTG - Polokwane International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 12780));//DUR - PTG



            if (flightCompany == "Kulula" && seatType == "Business" && departure == "DUR - King Shaka International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 10982));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 10982));//DUR - MQP



            if (flightCompany == "Kulula" && seatType == "Business" && departure == "DUR - King Shaka International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 12446));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "KIM - Kimberly Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 12446));//DUR - KIM



            if (flightCompany == "Kulula" && seatType == "Business" && departure == "DUR - King Shaka International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 11423));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "NTY - Pilanesberg International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 11423));//DUR - NTY

            //JHB

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "JHB - OR Tambo International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 4635));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "CPT - Cape Town International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 4635));//JHB - CPT


            if (flightCompany == "Kulula" && seatType == "Business" && departure == "JHB - OR Tambo International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 30964));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "BFN -Bloemfontein Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 30964));//JHB - BFN


            if (flightCompany == "Kulula" && seatType == "Business" && departure == "JHB - OR Tambo International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 9205));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "PLZ - Port Elizabeth Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 9205));//JHB - PLZ



            if (flightCompany == "Kulula" && seatType == "Business" && departure == "JHB - OR Tambo International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 4432));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "PTG - Polokwane International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 4432));//JHB - PTG



            if (flightCompany == "Kulula" && seatType == "Business" && departure == "JHB - OR Tambo International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 33090));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 33090));//JHB - MQP



            if (flightCompany == "Kulula" && seatType == "Business" && departure == "JHB - OR Tambo International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 13876));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "KIM - Kimberly Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 13876));//JHB - KIM



            if (flightCompany == "Kulula" && seatType == "Business" && departure == "JHB - OR Tambo International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 11560));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "NTY - Pilanesberg International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 11560));//JHB - NTY


            //CPT


            if (flightCompany == "Kulula" && seatType == "Business" && departure == "CPT - Cape Town International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 7250));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "BFN -Bloemfontein Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 7250));//CPT - BFN



            if (flightCompany == "Kulula" && seatType == "Business" && departure == "CPT - Cape Town International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 8801));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "PLZ - Port Elizabeth Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 8801));//CPT - PLZ



            if (flightCompany == "Kulula" && seatType == "Business" && departure == "CPT - Cape Town International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 11011));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "PTG - Polokwane International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 11011));//CPT - PTG




            if (flightCompany == "Kulula" && seatType == "Business" && departure == "CPT - Cape Town International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 6739));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 6739));//CPT - MQP




            if (flightCompany == "Kulula" && seatType == "Business" && departure == "CPT - Cape Town International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 6582));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "KIM - Kimberly Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 6582));//CPT - KIM




            if (flightCompany == "Kulula" && seatType == "Business" && departure == "CPT - Cape Town International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 7310));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "NTY - Pilanesberg International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 7310));//CPT - NTY


            //BFN

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "BFN -Bloemfontein Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 10066));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "PLZ - Port Elizabeth Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 10066));//BFN - PLZ


            if (flightCompany == "Kulula" && seatType == "Business" && departure == "BFN -Bloemfontein Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 69478));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "PTG - Polokwane International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 69478));//BFN - PTG



            if (flightCompany == "Kulula" && seatType == "Business" && departure == "BFN -Bloemfontein Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 21220));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 21220));//BFN - MQP



            if (flightCompany == "Kulula" && seatType == "Business" && departure == "BFN -Bloemfontein Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 20002));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "KIM - Kimberly Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 20002));//BFN - KIM



            if (flightCompany == "Kulula" && seatType == "Business" && departure == "BFN -Bloemfontein Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 15610));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "NTY - Pilanesberg International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 15610));//BFN - NTY


            //PLZ


            if (flightCompany == "Kulula" && seatType == "Business" && departure == "PLZ - Port Elizabeth Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 11069));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "PTG - Polokwane International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 11069));//PLZ - PTG


            if (flightCompany == "Kulula" && seatType == "Business" && departure == "PLZ - Port Elizabeth Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 11311));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 11311));//PLZ - MQP



            if (flightCompany == "Kulula" && seatType == "Business" && departure == "PLZ - Port Elizabeth Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 10789));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "KIM - Kimberly Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 10789));//PLZ - KIM



            if (flightCompany == "Kulula" && seatType == "Business" && departure == "PLZ - Port Elizabeth Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 11480));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "NTY - Pilanesberg International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 11480));//PLZ - NTY


            //PTG

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "PTG - Polokwane International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 49961));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 49961));//PTG - MQP

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "PTG - Polokwane International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 21812));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "KIM - Kimberly Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 21812));//PTG - KIM



            if (flightCompany == "Kulula" && seatType == "Business" && departure == "PTG - Polokwane International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 12480));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "NTY - Pilanesberg International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 12480));//PTG - NTY

            //MQP

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 22123));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "KIM - Kimberly Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 22123));//MQP - KIM

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 17550));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "NTY - Pilanesberg International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 17550));//MQP - NTY

            //KIM


            if (flightCompany == "Kulula" && seatType == "Business" && departure == "KIM - Kimberly Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 11952));

            if (flightCompany == "Kulula" && seatType == "Business" && departure == "NTY - Pilanesberg International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 11952));//KIM - NTY


            //FIRST FIRST FIRST FIRST KULULA KULULA KULULA KULULA

            if (flightCompany == "Kulula" && seatType == "First" && departure == "DUR - King Shaka International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 119826));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "JHB - OR Tambo International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 119826)); //DUR - JHB


            if (flightCompany == "Kulula" && seatType == "First" && departure == "DUR - King Shaka International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 113244));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "CPT - Cape Town International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 113244)); //DUR - CPT



            if (flightCompany == "Kulula" && seatType == "First" && departure == "DUR - King Shaka International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 78079));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "BFN -Bloemfontein Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 78079)); //DUR - BFN



            if (flightCompany == "Kulula" && seatType == "First" && departure == "DUR - King Shaka International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 101766));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "PLZ - Port Elizabeth Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 101766)); //DUR - PLZ



            if (flightCompany == "Kulula" && seatType == "First" && departure == "DUR - King Shaka International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 61812));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "PTG - Polokwane International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 61812));//DUR - PTG



            if (flightCompany == "Kulula" && seatType == "First" && departure == "DUR - King Shaka International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 61485));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 61485));//DUR - MQP



            if (flightCompany == "Kulula" && seatType == "First" && departure == "DUR - King Shaka International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 122131));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "KIM - Kimberly Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 122131));//DUR - KIM



            if (flightCompany == "Kulula" && seatType == "First" && departure == "DUR - King Shaka International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 100436));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "NTY - Pilanesberg International Airport" && destination == "DUR - King Shaka International Airport")
                return ((numSeats * 100436));//DUR - NTY

            //JHB

            if (flightCompany == "Kulula" && seatType == "First" && departure == "JHB - OR Tambo International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 112693));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "CPT - Cape Town International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 112693));//JHB - CPT


            if (flightCompany == "Kulula" && seatType == "First" && departure == "JHB - OR Tambo International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 80127));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "BFN -Bloemfontein Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 80127));//JHB - BFN


            if (flightCompany == "Kulula" && seatType == "First" && departure == "JHB - OR Tambo International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 114769));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "PLZ - Port Elizabeth Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 114769));//JHB - PLZ



            if (flightCompany == "Kulula" && seatType == "First" && departure == "JHB - OR Tambo International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 98460));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "PTG - Polokwane International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 98560));//JHB - PTG



            if (flightCompany == "Kulula" && seatType == "First" && departure == "JHB - OR Tambo International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 97080));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 97080));//JHB - MQP



            if (flightCompany == "Kulula" && seatType == "First" && departure == "JHB - OR Tambo International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 81447));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "KIM - Kimberly Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 81447));//JHB - KIM



            if (flightCompany == "Kulula" && seatType == "First" && departure == "JHB - OR Tambo International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 114578));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "NTY - Pilanesberg International Airport" && destination == "JHB - OR Tambo International Airport")
                return ((numSeats * 114578));//JHB - NTY


            //CPT


            if (flightCompany == "Kulula" && seatType == "First" && departure == "CPT - Cape Town International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 134804));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "BFN -Bloemfontein Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 134804));//CPT - BFN



            if (flightCompany == "Kulula" && seatType == "First" && departure == "CPT - Cape Town International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 100436));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "PLZ - Port Elizabeth Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 100436));//CPT - PLZ



            if (flightCompany == "Kulula" && seatType == "First" && departure == "CPT - Cape Town International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 134413));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "PTG - Polokwane International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 134413));//CPT - PTG




            if (flightCompany == "Kulula" && seatType == "First" && departure == "CPT - Cape Town International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 129009));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 129009));//CPT - MQP




            if (flightCompany == "Kulula" && seatType == "First" && departure == "CPT - Cape Town International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 133715));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "KIM - Kimberly Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 133715));//CPT - KIM




            if (flightCompany == "Kulula" && seatType == "First" && departure == "CPT - Cape Town International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 124449));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "NTY - Pilanesberg International Airport" && destination == "CPT - Cape Town International Airport")
                return ((numSeats * 124449));//CPT - NTY


            //BFN

            if (flightCompany == "Kulula" && seatType == "First" && departure == "BFN -Bloemfontein Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 136098));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "PLZ - Port Elizabeth Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 136098));//BFN - PLZ


            if (flightCompany == "Kulula" && seatType == "First" && departure == "BFN -Bloemfontein Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 138423));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "PTG - Polokwane International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 138342));//BFN - PTG



            if (flightCompany == "Kulula" && seatType == "First" && departure == "BFN -Bloemfontein Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 139741));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 139741));//BFN - MQP



            if (flightCompany == "Kulula" && seatType == "First" && departure == "BFN -Bloemfontein Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 129541));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "KIM - Kimberly Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 129541));//BFN - KIM



            if (flightCompany == "Kulula" && seatType == "First" && departure == "BFN -Bloemfontein Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 127889));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "NTY - Pilanesberg International Airport" && destination == "BFN -Bloemfontein Airport")
                return ((numSeats * 127889));//BFN - NTY


            //PLZ


            if (flightCompany == "Kulula" && seatType == "First" && departure == "PLZ - Port Elizabeth Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 134105));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "PTG - Polokwane International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 134105));//PLZ - PTG


            if (flightCompany == "Kulula" && seatType == "First" && departure == "PLZ - Port Elizabeth Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 128909));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 128909));//PLZ - MQP



            if (flightCompany == "Kulula" && seatType == "First" && departure == "PLZ - Port Elizabeth Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 119894));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "KIM - Kimberly Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 119894));//PLZ - KIM



            if (flightCompany == "Kulula" && seatType == "First" && departure == "PLZ - Port Elizabeth Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 142983));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "NTY - Pilanesberg International Airport" && destination == "PLZ - Port Elizabeth Airport")
                return ((numSeats * 142983));//PLZ - NTY


            //PTG

            if (flightCompany == "Kulula" && seatType == "First" && departure == "PTG - Polokwane International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 139938));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 139938));//PTG - MQP

            if (flightCompany == "Kulula" && seatType == "First" && departure == "PTG - Polokwane International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 136255));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "KIM - Kimberly Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 136255));//PTG - KIM



            if (flightCompany == "Kulula" && seatType == "First" && departure == "PTG - Polokwane International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 134995));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "NTY - Pilanesberg International Airport" && destination == "PTG - Polokwane International Airport")
                return ((numSeats * 134995));//PTG - NTY

            //MQP

            if (flightCompany == "Kulula" && seatType == "First" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 129637));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "KIM - Kimberly Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 129637));//MQP - KIM

            if (flightCompany == "Kulula" && seatType == "First" && departure == "MQP - Kruger Mpumalanga International Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 129932));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "NTY - Pilanesberg International Airport" && destination == "MQP - Kruger Mpumalanga International Airport")
                return ((numSeats * 129932));//MQP - NTY

            //KIM


            if (flightCompany == "Kulula" && seatType == "First" && departure == "KIM - Kimberly Airport" && destination == "NTY - Pilanesberg International Airport")
                return ((numSeats * 140864));

            if (flightCompany == "Kulula" && seatType == "First" && departure == "NTY - Pilanesberg International Airport" && destination == "KIM - Kimberly Airport")
                return ((numSeats * 140864));//KIM - NTY

            else
                return (0);
        }
        public double calcSpecialDiscount()
        {
            if (flightCompany == "Mango" && numSeats >= 3 && days >= 5)
                return (calcAmountDue() * 0.15);
            else if (flightCompany == "Mango" && numSeats >= 3)
                return (calcAmountDue() * 0.05);
            else if (flightCompany == "Mango" && days >= 5)
                return (calcAmountDue() * 0.05);


            if (flightCompany == "Kulula" && numSeats >= 3 && days >= 5)
                return (calcAmountDue() * 0.18);
            else if (flightCompany == "Kulula" && numSeats >= 3)
                return (calcAmountDue() * 0.08);
            else if (flightCompany == "Kulula" && days >= 5)
                return (calcAmountDue() * 0.08);

            else
                return (0);
        }
        public double calcFinalAmount()
        {
            return (calcAmountDue() - calcSpecialDiscount());
        }

        public string Locations()
        {
            return (departure + "\t"+destination);
        }

    
    }
}

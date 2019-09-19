/* TO DO:
 *     (9/19/2019)
 *     +(extra) for the credit card portion, use regex and limit the amount of
 *     characters in the text box to properly detect a credit card number just for fun. 
 *     
 *     +Credit Card needs to be able to be added to the list box as displayed in the
 *     homework assignment. This should be done in the button click event.
 */ 

using System;

enum RoomType { King, Queen, Double }

namespace SunReservationV2
{
    enum bedRoomType
    {
        King,
        Queen,
        Double
    }

    class Reservation
    {
        private bedRoomType roomType;
        const double TAX = .07;
        const double MEMBER_Discount = .10;
        const double KING_RATE = 200;
        const double QUEEN_RATE = 150;
        const double DOUBLE_RATE = 100;
        private bool discount;
        private string name;
        private DateTime checkOutDate;
        private DateTime checkInDate;

        public DateTime CheckIn { set { checkInDate = value; } }
        public DateTime CheckedOut
        {
            set
            {
                checkOutDate = value;
                if(checkOutDate <= checkInDate)
                {
                    throw (new Exception("Dates Error: checkout must be greater than check in date"));
                }
            }  
        }

        public bedRoomType BedType { set { roomType = value; } }
        public string Name { set { name = value; } }
        public bool Member { set { discount = value; } }

        public Reservation()
        {

        }

        private double GetBaseCost()
        {
            double baseCharge = 0;
            double winterRate;

            winterRate = (checkInDate.Month >= 1 && checkInDate.Month <= 4) ? 30 : 0;
            
            switch (roomType)
            {
                case bedRoomType.King:
                    baseCharge = KING_RATE + winterRate;
                    break;
                case bedRoomType.Queen:
                    baseCharge = QUEEN_RATE + winterRate;
                    break;
                case bedRoomType.Double:
                    baseCharge = DOUBLE_RATE + winterRate;
                    break;
            }
            return baseCharge;
        }

        public override string ToString()
        {
            double baseAmount;
            double amountOff;
            double taxAmount;
            double total;
            double daysCost;
            int reservedDays;
            string output;
            string pad = "".PadRight(20,' ');

            //for some reason doing a timespan t2 - t1 from a day apart is off by one.
            //for example 9/20/19 - 9/19/2019 results in a 0, but 9/21/19 - 9/19/2019
            //will result in 1 day(s) reserved. Thus here I have added + 1 to counter
            //the day unaccounted for. 
            reservedDays = (int)(checkOutDate - checkInDate).TotalDays + 1;

            baseAmount = GetBaseCost();
            daysCost = reservedDays * baseAmount;
            amountOff = (discount == true) ? daysCost * MEMBER_Discount : 0;
            taxAmount = daysCost * TAX;
            total = (daysCost + taxAmount) - amountOff;

            output = "Reservation:\n".PadRight(30, '-');
            output += $"\nName {name}";
            output += $"\nType of Room: {roomType.ToString()}";
            output += $"\n{reservedDays} night(s) at {baseAmount:C} is {(reservedDays * baseAmount):C}";
            output += $"\nDiscount {amountOff:C}";
            output += $"\nTax amount due: {taxAmount:C}";
            output += $"\nTotal amount due: {total:C}\nThank You!";

            return output;
        }
    }
}

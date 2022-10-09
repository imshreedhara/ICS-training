/* 3.
   I. Create a class library Project called Concession. Write a method called CalculateConcession(int age)  that takes age 
      as an input and calculates concession for travel as below:

	  If age<=5 then “Little Champs- Free Ticket” should be displayed
	  If age >60 then calculate 30% concession on the totalfare(Which is a constant Eg:500 / -) and Display “ Senior Citizen” + Calculated Fare
	  Else “Print Ticket Booked” + Fare.   */

using System;

namespace Concession
{
    public class Ticket_BookingDll
    {
       
        public float Concession_Amt;
        public int Total_Fare = 500;
        public float Calculated_Fare;

        public void CalculateConcession(int age)
        {
            if(age <= 5)
            {
                Console.WriteLine("Little Champs ---- Free Ticket");
            }

            else if (age > 60)
            {
                Concession_Amt = Convert.ToInt32(0.3f * Total_Fare);
                Console.WriteLine("Senior Citizon\t Calculated fare is : {0}", Total_Fare - Concession_Amt);
            }

            else
            {
                Console.WriteLine("Ticket Booked\t & the total Fare is : {0}", Total_Fare);
                Console.WriteLine(" ---------------- Thank you\t Happy Journey ---------------- ");
            }
        }
    }
}

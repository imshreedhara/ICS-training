
/*3.
  I.Create a class library Project called Concession. Write a method called CalculateConcession(int age)  that takes age 
     as an input and calculates concession for travel as below:

	If age<=5 then “Little Champs- Free Ticket” should be displayed
	If age >60 then calculate 30% concession on the totalfare(Which is a constant Eg:500 / -) and Display “ Senior Citizen” + Calculated Fare
	Else “Print Ticket Booked” + Fare. 

   II. Create a Console application with a Class called Program which has int TotalFare as Constant, Name, Age.  Accept Name, Age from the user and 
      call the CalculateConcession() function

      (Hint: Add required references)    */

using System;
using Concession;

namespace Qn_03
{
    class Program
    {
        public string Name;
        public int Age;

        static void Main(string[] args)
        {
            Console.WriteLine(" ------------ Welcome to XYZ Travels ------------ ");
            Program pg = new Program();
            
            Console.Write("Enter the Name of the Passenger :");
            pg.Name = Console.ReadLine();

            Console.Write("Age : ");
            pg.Age = Convert.ToInt32(Console.ReadLine());

            Ticket_BookingDll obj = new Ticket_BookingDll();
            obj.CalculateConcession(pg.Age);
            Console.ReadKey();
        }
    }
}

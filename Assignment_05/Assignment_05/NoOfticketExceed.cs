
/* 2. Create an console application to book train tickets. Create a Passanger class with (Name, Age) and write a function called 
      TicketBooking(int no_of_tickets) that takes no.of tickets to be booked. If the no of tickets is > 2 per booking, 
      raise an user defined exception, and print "cannot book more than 2 tickets". Else Print  "Ticket Booked Successfully". 
      Add a Test class to call TicketBooking method by accepting all required details.  */

using System;

namespace Assignment_05
{
    class ticketBookingException : ApplicationException
    {
        public ticketBookingException(string msg) : base(msg)
        {

        }
    }

    class PassangerExceptionEx
    {
        public int Age;
        public int no_of_tickets;
        public string Name;

        public void AcceptPassengerDetails()
        {
            Console.WriteLine("Enter the Number of tickets : ");
            no_of_tickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the name of Passanger : ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter Age :");
            Age = Convert.ToInt32(Console.ReadLine());

            TicketBooking(no_of_tickets);
        }

        public void TicketBooking(int no_of_tickets)
        {
            this.no_of_tickets = no_of_tickets;

            if (no_of_tickets > 2)
            {
                throw (new ticketBookingException("cannot book more than 2 tickets"));
            }
            else
            {
                Console.WriteLine("Ticket Booked Successfully");
            }
        }
    }

    class NoOfticketExceed
    {
        static void Main(string[] args)
        {
            PassangerExceptionEx obj = new PassangerExceptionEx();

            try
            {
                obj.AcceptPassengerDetails();
            }
            catch (ticketBookingException te)
            {
                Console.WriteLine(te.Message);
            }
            Console.Read();
        }
    }
}

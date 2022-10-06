using System;

/*  1. Create a Class Program which would be used to accepts two Strings - FirstName and LastName & call the static method Display() 
     that displays the first name in one line and the LastName in the second line after converting the same to upper case.  */

namespace Assignment_04
{
    public class Program
    {
        public string FirstName;
        public string LastName;

        static void Main(string[] args)
        {
           Program pg=new Program("shree","ranga");
            //pg.GetNames();
            pg.Display();
            Console.ReadKey();
        }

        public void GetNames()
        {
            Console.WriteLine("Enter First Name :");
            //string fN = Console.ReadLine();
            FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name :");
            string lN = Console.ReadLine();
            LastName = lN.ToUpper();
        }

        public Program(string fn, string ln)
        {
            FirstName = fn;
            LastName = ln;
        }


        public void Display()
        {
            Console.WriteLine("First Name is : {0}",FirstName.ToUpper());
            Console.WriteLine("Last Name is : {0}",LastName.ToUpper());
        }
    }
}

using System;
using Consession;


namespace Assignment_05
{
    class Program_LibraryEg
    {
        public string Name;
        public int Age;

        static void Main(string[] args)
        {
            Console.WriteLine(" ------------ Welcome to XYZ Travels ------------ ");
            Program_LibraryEg pg = new Program_LibraryEg();

            Console.Write("Enter the Name of the Passenger :");
            pg.Name = Console.ReadLine();

            Console.Write("Age : ");
            pg.Age = Convert.ToInt32(Console.ReadLine());

            ConcessionAmt obj = new ConcessionAmt();

            obj.CalculateConcession(pg.Age);
            Console.ReadKey();
        }

    }
}

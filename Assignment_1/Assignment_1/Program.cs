using System;
namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //EqualOrNot();

            //PositiveOrNot();

            //Airthmatic_Operation();

            //ForResult();

            TempConversionExample();

            Console.ReadKey();
        }


      
        /*  1.Write a C# Sharp program to accept two integers and check whether they are equal or not
            Test Data :
            Input 1st number: 5
            Input 2nd number: 5
            Expected Output : 5 and 5 are equal*/


        static void EqualOrNot()
        {
            int num1 = 5;
            int num2 = 5;

            if (num1 == num2)
            {
                Console.WriteLine("num1 & num2 are equal");
            }
            else
            {
                Console.WriteLine("num1 & num2 are not quual");
            }
        }
       

        /* 3. Write a C# Sharp program that takes two numbers as input and perform an operation (+,-,*,/) on them and displays the result of that operation. 

                Test Data
                Input first number: 20
                Input operation: -
                Input second number: 12
                Expected Output : 20 - 12 = 8      */

        static void Airthmatic_Operation()
        {
            int x, y;

            Console.WriteLine("Enter any 2 numbers");

            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("the value is:{0}", x - y);
        }


        /*4.Write a program which accepts marks of 5 students for C#,HTML and Sql (3 subjects),
            calculates the average and prints result as passed or failed
            If avg< 50 then failed else passed   */

        static void ForResult()
         {
             int CSharp, HTML, SQL;

             Console.WriteLine("Enter marks of all 3 subjects");

             for (int i = 1; i <= 5, i++)
             {
                 Console.WriteLine("Enter marks of CSharp : ");
                 CSharp = Convert.ToInt32(Console.ReadLine());

                 Console.WriteLine("Enter marks of HTML : ");
                 HTML = Convert.ToInt32(Console.ReadLine());

                 Console.WriteLine("Enter marks of SQL : ");
                 SQL = Convert.ToInt32(Console.ReadLine());
             }

         }



        //5.Write a program in C# to display temperature in Celsius. Accept the temperature in Fahrenheit.

        static void TempConversionExample()
        {
            double celsius;
            double fahrenheit;

            Console.WriteLine("Enter the temp in fahrenheit");
            fahrenheit = Double.Parse(Console.ReadLine());
            Console.WriteLine("Fahrenheit: " + fahrenheit);
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Celsius: " + celsius);
        }
    }
}


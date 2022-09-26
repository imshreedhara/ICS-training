using System;
namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            EqualOrNot();

            PositiveOrNot();

            Airthmatic_Operation();

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

            if (num1==num2)
            {
                Console.WriteLine("num1 & num2 are equal");
            }
            else
            {
                Console.WriteLine("num1 & num2 are not quual");
            }
        }
        
        static void PositiveOrNot()
        {
            int x = 14;
            if(x>=0)
            {
            Console.WriteLine("14 is a positive number");
            }
        }

       /* 3. Write a C# Sharp program that takes two numbers as input and perform an operation (+,-,*,/) on them and displays the result of that operation. 
 
        Test Data
            Input first number: 20
            Input operation: -
            Input second number: 12
            Expected Output :
            20 - 12 = 8      */

        static void Airthmatic_Operation()
        {
            int x, y,z;

            Console.WriteLine("Enter any 2 numbers");

            x = Convert.ToInt32(Console.ReadLine());
            y= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(""x - y);




        }

        /*4.Write a program which accepts marks of 5 students for C#,HTML and Sql (3 subjects),
            calculates the average and prints result as passed or failed
            If avg< 50 then failed else passed    */

        static void Result()
        {

        }

}

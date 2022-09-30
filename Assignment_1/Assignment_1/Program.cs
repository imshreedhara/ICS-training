using System;
namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //EqualOrNot();

            NumIsPositiveOrNot();

            //Airthmatic_Operation();

            //AirthmaticOperation();

            //ForStudentResult();

            //TempConversionExample();

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


        //Write a C# Sharp program to check whether a given number is positive or negative.  
	    //Test Data : 14
	    //Expected Output : 14 is a positive number

        static void NumIsPositiveOrNot()
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num>=0)
                Console.WriteLine("Given number is Positive");

            else
                Console.WriteLine("Given number is Negative");
        }


        /* 3. Write a C# Sharp program that takes two numbers as input and perform an operation (+,-,*,/) on them and displays the result of that operation. 

                Test Data
                Input first number: 20
                Input operation: -
                Input second number: 12
                Expected Output : 20 - 12 = 8      */

        static void AirthmaticOperation()
        {
            int option;
            int n1 = 20;
            int n2 = 12;

            Console.WriteLine("Option\t\tAction\n=========================");
            Console.WriteLine("1\t\tAddition");
            Console.WriteLine("2\t\tSubstract");
            Console.WriteLine("3\t\tMultiplication");
            Console.WriteLine("3\t\tDivision");

            Console.WriteLine("Refer above menu and enter your option");
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine(n1+n2);
                    break;

                case 2:
                    Console.WriteLine(n1-n2);
                    break;

                case 3:
                    Console.WriteLine(n1 * n2);
                    break;

                case 4:
                    Console.WriteLine(n1 / n2);
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

        }


        /*4.Write a program which accepts marks of 5 students for C#,HTML and Sql (3 subjects),
            calculates the average and prints result as passed or failed
            If avg< 50 then failed else passed   */

        static void ForStudentResult()
        {
            int Csharp;
            int html;
            int sql;
            int total;

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine("Enter Csharp marks for Student " + i);
                    Csharp = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter html marks for Student " + i);
                    html = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter sql marks for Student" + i);
                    sql = Convert.ToInt32(Console.ReadLine());
                    total = Csharp + html + sql;
                    total = total / 3;

                    if (total < 50)
                    {
                        Console.WriteLine("total  mark for student " + i + " is : " + total);
                        Console.WriteLine("student {0} is Failed", i);
                    }
                    else
                    {
                        Console.WriteLine("total  mark for student " + i + " is : " + total);
                        Console.WriteLine("student {0} is passed", i);
                    }

                }

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
            Console.WriteLine("Temperature in Celsius is : " + celsius);
        }
    }
}


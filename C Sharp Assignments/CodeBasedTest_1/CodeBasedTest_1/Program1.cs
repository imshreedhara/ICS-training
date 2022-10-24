
/*1.Write a program to find the Sum and the Average points scored by the teams in the IPL. Create a Class called Cricket that 
    has a function called Pointscalculation(int no_of_matches) that takes no.of matches as input and accepts that many scores 
    from the user. The function should then display the Average and Sum of the scores */

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeBasedTest_1
{   
    class Cricket
    {
        Cricket cricket = new Cricket();

        public static List<int> PointsCalculation(int no_of_matches)
        {
            int avg;
            int sum=0;

            List<int> scores = new List<int>();

            for (int i = 1; i <= no_of_matches; i++)
            {
                Console.WriteLine("Enter the score for match {0}: ", i);
                int marks = Convert.ToInt32(Console.ReadLine());
                scores.Add(marks);
            }

            foreach (int s in scores)
            {
                sum =sum+s;
            }

            void Avg_Calculation(int Total, int matches)
            {
                Console.WriteLine("The Total score of all matches are: " + sum);
                avg = sum / no_of_matches;
                Console.WriteLine("The avg score is: " + avg);
            }

            Avg_Calculation(sum, no_of_matches);

            return scores.ToList();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of matches: ");
            int matches = Convert.ToInt32(Console.ReadLine());
            Cricket.PointsCalculation(matches);
            Console.ReadKey();
        }
    }
}

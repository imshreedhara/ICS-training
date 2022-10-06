using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//   2.Create a Program to count the no. of occurrences of a letter in a given string (for example in a string called “OOPS PROGRAMMING”, O appears 3 times)
//     Hint: Accept a string and also the letter to be counted


namespace Assignment_4_2
{
    public class CountOccurrencesOfCharacter
    {
        public static void Main()
        {
            string str = "OOPS PROGRAMMING";
            char ch = 'O';

            int freq = str.Count(f => (f == ch));
            Console.WriteLine("Number of occurrences of a letter {0} in a given string {1} is : {2} ",ch,str,freq);
            Console.ReadKey();
        }
    }
}
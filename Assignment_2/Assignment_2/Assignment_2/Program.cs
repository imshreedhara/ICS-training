using System;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assigning the array elements at the time of declaration
            int[,] arr = {{11,12,13,14},
                          {21,22,23,24},
                          {31,32,33,34}};
            //printing values of array using for each loop
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
            //printing the values of array using nested for loop
            for (int i = 0; i <= arr.Length-1; i++)
            {
                for (int j = 0; j <= arr[i].Length - 1; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}

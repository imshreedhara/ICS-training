using System;

//1.Write a program in C# to accept a word from the user and display the length of it.
//2.Write a program in C# to accept a word from the user and display the reverse of it. 
//3.Write a program in C# to accept two words from user and find out if they are same. 
//4.Write a program in C# to accept a word and to find out whether the given word is a palindrome or not.

namespace Assignment_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            //LengthOf_String();

            //ReverseOfString();

            //WordsOrEqualorNot();

            //PalindromeorNot();

            //AvgValueOfArrayElements();

            //MaxnMinofArray();

            Accept_10_Marks();

            Console.ReadKey();
        }

        static void LengthOf_String()
        {
            Console.WriteLine("Enter any  word:");
            string str = Console.ReadLine();
            int len = str.Length;
            Console.WriteLine(len);
        }

        static void ReverseOfString()
        {
            Console.WriteLine("Enter any word :");
            string stringInput = Console.ReadLine();
            char[] charArray = stringInput.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(new string(charArray));
        }

        static void WordsOrEqualorNot()
        {
            {
                Console.WriteLine("Enter first Word :");
                string str1 = Console.ReadLine();
                Console.WriteLine("Enter second value :");
                string str2 = Console.ReadLine();

                if (str1 == str2)
                    Console.WriteLine("Both words are equal");

                else
                    Console.WriteLine("Both words are not equal");
            }
        }

        static void PalindromeorNot()
        {
            Console.WriteLine("Enter a word :");
            string myInput = Console.ReadLine();
            string str = myInput;
            char[] charArray = myInput.ToCharArray();
            Array.Reverse(charArray);

            string rev = new string(charArray);

            if (str == rev)
            {
                Console.WriteLine(rev + " is palindrome");
            }
            else
                Console.WriteLine("not a palindrome string");
        }

        static void AvgValueOfArrayElements()
        {
            int[] arr = new int[4] { 5, 1, 8, 2 };
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }

            float avg = sum / arr.Length;

            Console.WriteLine("Average of an array:" + avg);
        }

        static void MaxnMinofArray()
        {
            int[] arr = new int[5] { 62, 5, 31, 55, 32 };
            int max = arr[0];
            int min = arr[4];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            for (int j = 1; j < arr.Length; j++)
            {
                if (arr[j] < min)
                {
                    min = arr[j];
                }
            }
            Console.WriteLine("max value of an array: " + max);
            Console.WriteLine("min value of an array: " + min);
        }

        static void Accept_10_Marks()
        {
            int[] nums = new int[] { 7, 200, 89, 82, 23, 70, 40, 08, 54, 23 };

            int i = 0;

            for (i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    int z = nums[i];
                    nums[i] = nums[i + 1];
                    nums[i + 1] = z;
                }
            }
            Console.WriteLine("Max value is {0}", nums[i]);


            for (i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] < nums[i + 1])
                {
                    int z = nums[i];
                    nums[i] = nums[i + 1];
                    nums[i + 1] = z;
                }
            }
            Console.WriteLine("Min value is {0}", nums[i]);


            for (int n=nums.Length-1;n>=1;n--)
            {
                for (i = 0; i < n; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        int z = nums[i];
                        nums[i] = nums[i + 1];
                        nums[i + 1] = z;
                    }
                }
            }
            Console.WriteLine("Ascending order of an array is :");

            foreach(int p in nums)
            {
                Console.WriteLine(p);
            }

            for (int n = nums.Length - 1; n >= 1; n--)
            {
                for (i = 0; i > n; i++)
                {
                    if (nums[i] < nums[i + 1])
                    {
                        int z = nums[i];
                        nums[i] = nums[i + 1];
                        nums[i + 1] = z;
                    }
                }
            }

            Console.WriteLine("Descending order of an array is :");

            foreach (int p in nums)
            {
                Console.WriteLine(p);
            }
        }
    }
}

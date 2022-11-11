
/* 2. Write a class Box that has Length and breadth as its members.
      Write a function that adds 2 box objects and stores in the 3rd.
      Create a Test class to execute the above.   */


using System;

namespace CodeBasedTest_1
{
    class Box
    {
        public int length { get; set; }
        public int breadth { get; set; }

        public static Box operator +(Box obj1, Box obj2)
        {
            Box box_obj = new Box();
            box_obj.length = obj1.length + obj2.length;
            box_obj.breadth = obj1.breadth + obj2.breadth;
            return box_obj;
        }

        class Testclass
        {
            static void Main()
            {
                Box b1 = new Box();
                Box b2 = new Box();

                b1.length = 40; b1.breadth = 45;
                b2.length = 50; b2.breadth = 40;

                Box b3 = b1 + b2;
                Console.WriteLine("The total Length and Breadth of 2 Boxes are : {0} & {1}",
                                    b3.length, b3.breadth);

                Console.ReadLine();
            }
        }
    }
}

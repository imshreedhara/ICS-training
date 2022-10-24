
/* 2.Write a class Box that has Length and breadth as its members. Write a function that adds 2 box objects and 
     stores in the 3rd. Create a Test class to execute the above  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBasedTest_1_2
{
    class Box
    {
        public float length = 10;
        public float breadth = 5;

        public static void Box_1()
        {

        }

        public static void Box_2()
        {

        }

        static void Main(string[] args)
        {
            MulticastDelegate Box3 = new MulticastDelegate(Box3);
            AddBoxes += Box_1;
            AddBoxes += Box_2;

        }
    }
}

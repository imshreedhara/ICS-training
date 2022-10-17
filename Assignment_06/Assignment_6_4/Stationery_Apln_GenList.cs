using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 4.Create a simple Stationery application to add items and display added items using Generic List collections

namespace Assignment_6_4
{
    class Stationery_Apln_GenList
    {
        static void Main(string[] args)
        {
            List<string> stationery_items = new List<string>();
            stationery_items.Add("Books");
            stationery_items.Add("Pen");
            stationery_items.Add("Pencil");
            stationery_items.Add("Eraser");
            stationery_items.Add("Bag");

            Console.WriteLine("The list of newly added Stationery Items  ");

            foreach (string items in stationery_items)
            {
                Console.WriteLine(items);
            }
            Console.ReadKey();
        }
    }
}

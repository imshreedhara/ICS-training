/*3.
 * Create a Class called Products with Productid, Product Name, Price. Accept 10 Products,
   sort them based on the price, and display the sorted Products */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_06
{
    public class Product_Sorting
    {
        public int Product_Id { get; set; }
        public string Product_Name { get; set; }
        public float Price { get; set; }
    }

    public class Product_SortPG
    {
        int[] id = new int[10];
        string[] name = new string[10];
        float[] amount = new float[10];

        static void Main(string[] args)
        {
            Product_SortPG obj = new Product_SortPG();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter product Id for product {0}: ", i + 1);
                obj.id[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter product Name for product {0}: ", i + 1);
                obj.name[i] = Console.ReadLine();
                Console.WriteLine("Enter product Price for product {0}: ", i + 1);
                obj.amount[i] = Convert.ToSingle(Console.ReadLine());
            }

            List<Product_Sorting> products = new List<Product_Sorting>
            {
                new Product_Sorting { Product_Id = obj.id[0], Product_Name = obj.name[0], Price = obj.amount[0] },
                new Product_Sorting { Product_Id = obj.id[1], Product_Name = obj.name[1], Price = obj.amount[1] },
                new Product_Sorting { Product_Id = obj.id[2], Product_Name = obj.name[2], Price = obj.amount[2] },
                new Product_Sorting { Product_Id = obj.id[3], Product_Name = obj.name[3], Price = obj.amount[3] },
                new Product_Sorting { Product_Id = obj.id[4], Product_Name = obj.name[4], Price = obj.amount[4] },
                new Product_Sorting { Product_Id = obj.id[5], Product_Name = obj.name[5], Price = obj.amount[5] },
                new Product_Sorting { Product_Id = obj.id[6], Product_Name = obj.name[6], Price = obj.amount[6] },
                new Product_Sorting { Product_Id = obj.id[7], Product_Name = obj.name[7], Price = obj.amount[7] },
                new Product_Sorting { Product_Id = obj.id[8], Product_Name = obj.name[8], Price = obj.amount[8] },
                new Product_Sorting { Product_Id = obj.id[9], Product_Name = obj.name[9], Price = obj.amount[9] },
            };

            Display(products);
            Console.Read();
        }

        public static void Display(List<Product_Sorting> products)
        {
            Console.WriteLine();
            var val = products.OrderBy(a => a.Price).ToList();
            foreach (var p in val)
            {
                Console.WriteLine("name: {0}\tid: {1}\tprice: {2} ", p.Product_Name, p.Product_Id, p.Price);
            }
        }
    }
}
using System;

/* 4. Create a class called Customer with Customerid, Name, Age, Phone, City. Write a constructor with no arguments and 
      another constructor with all information.
      Write a method called DisplayCustomer(), which is called directly without any object. Also  include destructor   */

namespace Assignment_04
{
    public class Customer
    {
        public int CustomerId;
        public string Name;
        public int Age;
        public string PhoneNo;
        public string City;

        static void Main(string[] args)
        {
            Customer obj1 = new Customer();
            obj1.DisplayCustomer();

            Console.WriteLine("=================================================");

            Customer obj2 = new Customer(123, "Shreedhara", 24, "1234567890", "Bangalore");
            obj2.DisplayCustomer();
            Console.ReadKey();
        }


        public Customer()
        {
            Console.WriteLine("Customer with no Parameters");
        }

        public Customer(int id, string name, int age, string phNo, string town)
        {
            CustomerId = id;
            Name = name;
            Age = age;
            PhoneNo = phNo;
            City = town;
            Console.WriteLine("Customer with Parameters");
        }

        public void DisplayCustomer()
        {
            Console.WriteLine(" -------------------- Customer Details --------------------");
            Console.WriteLine("Customewr Id :{0}\nName : {1}\nAge : {2}\nPhone No : {3}\nCity :{4}", CustomerId, Name, Age, PhoneNo, City);
        }
    }
}

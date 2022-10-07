using System;


/*3.Create a class called Saledetails which has data members like Salesno, Productno, Price, dateofsale, Qty, TotalAmount
    Create a method called Sales() that takes qty, Price details of the object and updates the TotalAmount as Qty*Price
    Pass the other information like SalesNo, Productno, Price, Qty and Dateof sale through constructor
    call the show data method to display the values.

    Hint : Use This pointer  */

namespace Assignment_04
{
    public class Saledetails
    {
        public int Salesno;
        int ProductNo;
        float Price;
        string DateOfSale;
        int Qty;
        float TotalAmount;

        static void Main(string[] args)
        {
            Saledetails sd = new Saledetails(12, 90, 300,"06-10-2022");

            Console.WriteLine("Enter the Qty : ");
            sd.Qty = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Price : ");
            sd.Price = Convert.ToSingle(Console.ReadLine());

            //Saledetails sd1 = new Saledetails();

            sd.Sales(sd.Qty, sd.Price);
            sd.ShowSalesDetail();
            Console.ReadKey();
        }

        public void Sales(int Qty, float Price)
        {
            this.Qty = Qty;
            this.Price = Price;

            TotalAmount = Qty * Price;
        }

        public Saledetails(int Salesno, int ProductNo, float Price, string DateOfSale)
        {
            this.Salesno = Salesno;
            this.ProductNo = ProductNo;
            this.Price = Price;
            this.DateOfSale = DateOfSale;
        }

        public void ShowSalesDetail()
        {
            Console.WriteLine(" -------------------- Sales Detail are -------------------- ");
            Console.WriteLine("Sales No :{0}\nProductNo : {1}\nPrice : {2}\nDateOfSale : {3}\nQty : {4}\nTotal Amount : {5}", Salesno, ProductNo, Price, DateOfSale, Qty, TotalAmount);
        }
    }
}
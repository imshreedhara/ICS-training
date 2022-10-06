using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*3.Create a class called Saledetails which has data members like Salesno, Productno, Price, dateofsale, Qty, TotalAmount
    Create a method called Sales() that takes qty, Price details of the object and updates the TotalAmount as Qty*Price
    Pass the other information like SalesNo, Productno, Price, Qty and Dateof sale through constructor
    call the show data method to display the values.

    Hint : Use This pointer  */

namespace Assignment_4_3
{
    public class Saledetails
    {
        public int Salesno;
        int Productno;
        float Price;
        DateTime dateofsale;
        int Qty;
        int TotalAmount;

        static void Main(string[] args)
        {

        }

        public void Sales(int Qty,int Price)
        {
            this.Qty = Qty;
            this.Price = Price;
        }
    }
}

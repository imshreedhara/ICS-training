/*Qn.2
 * Create a structure 
   struct Books 
   private string title;
   private string author;
   private string subject;
   private int book_id;

Include 2 methods called GetValues() and ShowValues() to accept and display details.

create a Class called TestStructures that invokes the above methods of the structure to accept and display the details of the book */

using System;

namespace Assignment_6_2
{
    struct Books
    {
        private string title;
        private string author;
        private string subject;
        private int book_id;

        public void GetValues()
        {
            Console.Write("Book Title : ");
            title = Console.ReadLine();
            Console.Write("Author : ");
            author = Console.ReadLine();
            Console.Write("Subject : ");
            subject = Console.ReadLine();
            Console.Write("Book Id : ");
            book_id = Convert.ToInt32(Console.ReadLine());            
        }

        public void ShowValues()
        {
            Console.WriteLine("Book Title : {0}\nAuthor Name : {1}\nSubject : {2}\nBook Id : {3}",title,author,subject,book_id);
        }
    }

    class TestStructures
    {
        static void Main(string[] args)
        {
            Books books = new Books();
            books.GetValues();
            Console.WriteLine("***********************");
            books.ShowValues();
            Console.ReadKey();
        }
    }
}

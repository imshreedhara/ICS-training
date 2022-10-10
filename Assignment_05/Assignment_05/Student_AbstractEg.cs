
/* 1. Create an Abstract class Student with  Name, StudentId, Grade as members and also an abstract method Boolean Ispassed(grade) which 
    takes grade as an input and checks whether student passed the course or not.  

    Create 2 Sub classes Undergraduate and Graduate that inherits all members of the student and overrides Ispassed() method 

    For the UnderGrad class, if the grade is above 70.0, then isPassed returns true, otherwise it returns false. 
    For the Grad class, if the grade is above 80.0, then isPassed returns true, otherwise returns false. */

using System;
namespace Assignment_05
{
    abstract class Student
    {
        public string Name;
        public int StudentId;
        public float Grade;

        public abstract bool Ispassed(float Grade);
    }

    class Undergraduate : Student
    {

        public override bool Ispassed(float Grade)
        {
            if (Grade > 70.0f)
            {
                Console.WriteLine("Under Graduate student got Passed");
                return true;
            }
            else
            {
                Console.WriteLine("Under Graduate student got Failed");
                return false;
            }
        }
    }

    class Graduate : Student
    {
        public override bool Ispassed(float Grade)
        {
            if (Grade > 80.0f)
            {
                Console.WriteLine("Graduate student Passed");
                return true;
            }
            else
            {
                Console.WriteLine("Graduate student Failed");
                return false;
            }
        }
    }

    class Student_AbstractEg  //Student_AbstractEx
    {
        static void Main(string[] args)
        {
            Student obj1 = new Undergraduate();
            Console.Write("Enter Name of Undergraduate Student : ");
            obj1.Name = Console.ReadLine();
            Console.WriteLine("Enter Id of Undergraduate Student : ");
            obj1.StudentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Grade of Undergraduate Student : ");
            obj1.Grade = Convert.ToSingle(Console.ReadLine());
            obj1.Ispassed(obj1.Grade);

            Console.WriteLine("**********************************");

            Student obj2 = new Graduate();
            Console.Write("Enter Name of Graduate Student : ");
            obj2.Name = Console.ReadLine();
            Console.WriteLine("Enter Id of Graduate Student : ");
            obj2.StudentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Grade of Graduate Student : ");
            obj2.Grade = Convert.ToSingle(Console.ReadLine());
            obj2.Ispassed(obj2.Grade);

            Console.ReadKey();
        }
    }
}

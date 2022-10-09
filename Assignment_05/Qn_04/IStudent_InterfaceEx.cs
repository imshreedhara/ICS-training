
/* 4.Create an Interface IStudent with int StudentId and string Name as Properties, void ShowDetails() as its method.

    Create 2 classes Dayscholar and Resident that implements the interface Properties and Methods.ShowDetails() should show
    DaysScholar details and Resident Details accordingly.  */

using System;

namespace Qn_04
{
    class IStudent_InterfaceEx
    {
        public static void Main(string[] args)
        {
            Resident r1 = new Resident();
            r1.GetResident_StuDetails();
            r1.ShowDetatils();

            Console.WriteLine("******************");

            DayScholar d1 = new DayScholar();
            d1.GetDayScholar_StuDetails();
            d1.ShowDetatils();
            Console.ReadKey();
        }
    }

    interface IStudent
    {
        int StudentId { get; set; }
        string Name { get; set; }
        void ShowDetatils();
    }

    public class DayScholar : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public int _StudentId
        {
            set { StudentId = value; }
            get { return StudentId; }
        }

        public string _Name
        {
            set { Name = value; }
            get { return Name; }
        }

        public void GetDayScholar_StuDetails()
        {
            Console.Write("Enter DayScholar Student Id :");
            StudentId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter DayScholar Student Name : ");
            Name = Console.ReadLine();
        }

        public void ShowDetatils()
        {
            Console.WriteLine(" ---------------------------------------- Day Scholar Student Details ---------------------------------------- ");
            Console.WriteLine("StudentId : {0}\nName : {1}", StudentId, Name);
        }
    }

    public class Resident : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public int _StudentId
        {
            set { StudentId = value; }
            get { return StudentId; }
        }

        public string _Name
        {
            set { Name = value; }
            get { return Name; }
        }

        public void GetResident_StuDetails()
        {
            Console.Write("Enter Resident Student Id :");
            StudentId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Resident Student Name : ");
            Name = Console.ReadLine();
        }

        public void ShowDetatils()
        {
            Console.WriteLine(" ---------------------------------------- Resident Student Details ---------------------------------------- ");
            Console.WriteLine("StudentId : {0}\nName : {1}", StudentId, Name);
        }
    }
}
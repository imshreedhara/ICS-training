using System;

// 6.Create a Class called Doctor with RegnNo, Name, Feescharged as Private members. Allow values to be set and also to display the same.

namespace Assignment_4_6
{
    class Doctor
    {
        private int RegnNo { get; set; }
        private string Name { get; set; }
        private int FeesCharged { get; set; }

        public int _RegNo
        {
            set
            {
                RegnNo = value;
            }
            get
            {
                return RegnNo;
            }
        }

        public string _name
        {
            set
            {
                Name = value;
            }
            get
            {
                return Name;
            }
        }

        public int _FeesCharged
        {
            set
            {
                FeesCharged = value;
            }
            get
            {
                return FeesCharged;
            }
        }

        public void SetValues()
        {
            Console.Write("Enter the Doctor's Reg No : ");
            RegnNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the name of the Doctor : ");
            Name = Console.ReadLine();

            Console.Write("Enter the Charged Fee Amount : ");
            FeesCharged = Convert.ToInt32(Console.ReadLine());
        }

        public void PrintValues()
        {
            Console.WriteLine(" ------------ Details of the Dector ------------");
            Console.WriteLine("RegnNo :{0}\nName : {1}\nFees charged : {2}",RegnNo,Name,FeesCharged);
        }       
    }
    
    public class MyClass
    {
        static void Main(string[] args)
        {
            Doctor obj = new Doctor();
            obj.SetValues();
            obj.PrintValues();

            Console.ReadKey();
        }       
    }   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinite_CaseStudy_1
{
    public class App
    {
        static void Main(string[] args)
        {
            App app = new App();

            //app.Scenario_1();
            //Console.WriteLine();
            //app.Scenario_2();
            //Console.WriteLine();
            app.Scenario_3();

            Console.ReadKey();
        }

        #region
        
        public void Scenario_1()
        {
            //Writing a method called as scenario_1 to:
            //Create few objects of Student class
            //Call the display method of Info class

            Student std1 = new Student(1, "Shreedhara", Convert.ToDateTime("05/01/1987"));
            Student std2 = new Student(2, "Niranjan", Convert.ToDateTime("24/05/1967"));
            Student std3 = new Student(3, "Kavitha", Convert.ToDateTime("30/06/1980"));
            Student std4 = new Student(4, "SriHarshini", Convert.ToDateTime("17/09/1989"));

            Info info = new Info();
            Console.WriteLine("Std_Id \t Name \t\t   DOB");
            Console.WriteLine("----------------------------------");
            info.Display(std1);
            info.Display(std2);
            info.Display(std3);
            info.Display(std4);

            Console.WriteLine() ;

            Course c1 = new Course(101, "CCNA", "80 Hrs", 25000);
            Course c2 = new Course(102, "CCNP", "90 Hrs", 40000);
            Course c3 = new Course(103, "CCIE", "70 Hrs", 55000);

            Console.WriteLine(" Id     Name   Duration   Fee");
            Console.WriteLine("----------------------------------");

            info.Display(c1);
            info.Display(c2);
            info.Display(c3);
        }

        public void Scenario_2()
        {
            // Write a method called as scenario_2 to:
            // Create array of Student class and store few objects in it
            // Demonstrate how to iterate over the array and call the display method for each student

            Student[] students = new Student[4];

            students[0] = new Student(11, "Shreedhara", Convert.ToDateTime("05/01/1998"));
            students[1] = new Student(12, "Niranjan", Convert.ToDateTime("24/05/1967"));
            students[2] = new Student(13, "Kavitha", Convert.ToDateTime("17/09/1989"));
            students[3] = new Student(14, "SriHarshini", Convert.ToDateTime("17/09/1989"));

            Info info = new Info();
            Console.WriteLine("Std_Id \t Name \t\t   DOB");
            Console.WriteLine("----------------------------------");

            info.Display(students[0]);
            info.Display(students[1]);
            info.Display(students[2]);
            info.Display(students[3]);
            Console.WriteLine();

            Course[] courses = new Course[3];
            courses[0] = new Course(101, "CCNA", "80 Hrs", 25000);
            courses[1] = new Course(102, "CCNP", "90 Hrs", 40000);
            courses[2] = new Course(103, "CCIE", "70 Hrs", 72000);

            Console.WriteLine(" Id     Name   Duration   Fee");
            Console.WriteLine("----------------------------------");

            info.Display(courses[0]);
            info.Display(courses[1]);
            info.Display(courses[2]);
        }

        public void Scenario_3()
        {
            //  Write a method called as scenario_3 to:
            //  Taking Student data as input from the user & storing it in the Student object

            // -Repeating the above process using loops

            // -Using Arrays to store the Student objects as covered in scenario2
            //- Finally iterating over the array to display all the collected data

            try
            {
                Console.Write("Enter the total number of students : ");
                int StdCount = Convert.ToInt32(Console.ReadLine());

                Student[] students = new Student[StdCount];

                Console.WriteLine("Enter all the details of Students  : ");

                for (int i = 0; i <= StdCount - 1; i++)
                {
                    Console.Write("Enter the id of student {0} : ", i + 1);
                    int std_Id = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter the Name of student {0} : ", i + 1);
                    string std_Name = Console.ReadLine();

                    Console.Write("Enter the DOB of Student {0} : ", i + 1);
                    DateTime Std_DOB = Convert.ToDateTime(Console.ReadLine());

                    students[i] = new Student(std_Id, std_Name, Std_DOB);
                    Info info = new Info();
                    info.Display(students[i]);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Taking the Course Details from the User
            try
            {
                Console.Write("Enter the total number of Courses you want to add : ");
                int Course_Count = Convert.ToInt32(Console.ReadLine());

                Course[] courses = new Course[Course_Count];

                Console.WriteLine("Enter all the details of Course  : ");

                for (int i = 0; i <= Course_Count - 1; i++)
                {
                    Console.WriteLine("Enter the ID of Course {0} : ", i + 1);
                    int CId = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter the Name of Course {0} : ", i + 1);
                    string cName = Console.ReadLine();

                    Console.WriteLine("Course Duration : ");
                    string cDuration = Console.ReadLine();

                    Console.WriteLine("Enter Course Fee {0} : ");
                    float cFee = Convert.ToSingle(Console.ReadLine());

                    courses[i] = new Course(CId, cName, cDuration, cFee);
                    Info info = new Info();
                    info.Display(courses[i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        #endregion
    }
}


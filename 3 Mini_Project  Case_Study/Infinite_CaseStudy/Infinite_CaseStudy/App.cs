using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinite_CaseStudy
{
    class App
    {
        static void Main(string[] args)
        {
            //App app = new App();
            //app.Scenario_1();
            //app.Scenario_2();
            //app.Scenario_3();

            AppEngine ae = new AppEngine();
            Course course = new Course();
            Student student = new Student();
            Info info = new Info();

            ae.Introduce(course);
           
            ae.Register(student);

            var std_List = ae.ListOfStudents();         
            foreach(var a in std_List)
            {
                info.sDisplay(a);
            }

            var course_List = ae.ListOfCourses();
            foreach (var b in course_List)
            {
                info.cDisplay(b);
            }

            ae.Enroll(student,course);

           var enroll= ae.ListOfEnrollments();
           for (int i = 0; i < enroll.Count(); i++)
            {
                if (enroll[i] != null)
                {
                    info.eDisplay(enroll[i]);
                }
                else
                {
                    Console.WriteLine("press enter key to Exit");
                    break;
                }
            }



            Console.ReadKey();
        }

        #region

        public void Scenario_1()
        {
            // Write a method called as scenario_1 to:
            // Create few objects of Student class
            // Call the display method of Info class

            Student std1 = new Student();
            std1.id = 1;
            std1.name = "Shreedhara";
            std1.dateofbirth = Convert.ToDateTime("05/01/1987");

            Student std2 = new Student();
            std2.id = 2;
            std2.name = "Niranjan";
            std2.dateofbirth = Convert.ToDateTime("24/05/1967");

            Student std3 = new Student();
            std3.id = 3;
            std3.name = "Kavitha ";
            std3.dateofbirth = Convert.ToDateTime("30/06/1980");

            Student std4 = new Student();
            std4.id = 4;
            std4.name = "Sri Harshini";
            std4.dateofbirth = Convert.ToDateTime("17/09/1989");

            Info info = new Info();
            Console.WriteLine("Std_Id \t Name \t\t   DOB");
            Console.WriteLine("----------------------------------");
            info.sDisplay(std1);
            info.sDisplay(std2);
            info.sDisplay(std3);
            info.sDisplay(std4);
        }

        public void Scenario_2()
        {
            // Write a method called as scenario_2 to:
            // Create array of Student class and store few objects in it
            // Demonstrate how to iterate over the array and call the display method for each student

            Student[] students = new Student[4];

            students[0] = new Student();
            students[0].id = 11;
            students[0].name = "Shreedhara";
            students[0].dateofbirth = Convert.ToDateTime("05/01/1987");

            students[1] = new Student();
            students[1].id = 12;
            students[1].name = "Niranjan";
            students[1].dateofbirth = Convert.ToDateTime("24/05/1967");

            students[2] = new Student();
            students[2].id = 13;
            students[2].name = "Kavitha ";
            students[2].dateofbirth = Convert.ToDateTime("30/06/1980");

            students[3] = new Student();
            students[3].id = 14;
            students[3].name = "Sri Harshini";
            students[3].dateofbirth = Convert.ToDateTime("17/09/1989");

            Info info = new Info();
            Console.WriteLine("Std_Id \t Name \t\t   DOB");
            Console.WriteLine("----------------------------------");

            foreach (var b in students)
            {
                info.sDisplay(b);
            }

            //info.cDisplay(students[0]);
            //info.cDisplay(students[1]);
            //info.cDisplay(students[2]);
            //info.cDisplay(students[3]);
        }

        //public void Scenario_3()
        //{
        //    //  Write a method called as scenario_3 to:
        //    //  Take Student data as input from the user, store it in Student object

        //    // -Repeat the above process using loops

        //    // -Use Arrays to store the Student objects as covered in scenario2
        //    //- Finally iterate over the array to display all the collected data

        //    Console.Write("Enter the total number of students : ");
        //    int StdCount = Convert.ToInt32(Console.ReadLine());

        //    Student[] students = new Student[StdCount];

        //    for (int i = 0; i <= StdCount - 1; i++)
        //    {
        //        students[i] = new Student();

        //        Console.Write("Enter the id of student {0} : ", i + 1);
        //        int std_Id = Convert.ToInt32(Console.ReadLine());
        //        students[i].id = std_Id;

        //        Console.Write("Enter the Name of student {0} : ", i + 1);
        //        string std_Name = Console.ReadLine();
        //        students[i].name = std_Name;

        //        Console.Write("Enter the DOB of Student {0} : ", i + 1);
        //        DateTime Std_DOB = Convert.ToDateTime(Console.ReadLine());
        //        students[i].dateofbirth = Std_DOB;

        //        Info i = new Info();

        //        foreach (var b in Course)
        //        {
        //            i.cDisplay(b);
        //        }

        //        //Info info = new Info();
        //        //info.Display(students[i]);


        //    }
        //}

        #endregion

    }
}

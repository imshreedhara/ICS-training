using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinite_CaseStudy
{
    public abstract class UserInterface
    {
        public void showFirstScreen()
        {
            try
            {
                Console.WriteLine("Welcome to SMS(Student Mgmt. System) v1.0");
                Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin");
                Console.WriteLine("Enter your choice ( 1 or 2 ) : ");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        showStudentScreen();
                        break;
                    case 2:
                        showAdminScreen();
                        break;
                }
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
                Console.WriteLine("Please Enter the correct choice...and try again");
            }
        }
        public void showStudentScreen()
        {
            try
            {
                Console.WriteLine("welcome to student screen");
                Console.WriteLine("1.student registration\t 2.showFirstScreen");
                Console.WriteLine("Enter your choice ( 1 or 2  ) : ");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        showStudentRegistrationScreen();
                        break;
                    case 2:
                        showFirstScreen();
                        break;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please Enter the correct choice...and try again");
            }
        }
        public void showAdminScreen()
        {
            try
            {
                Console.WriteLine("welcome to Admin Screen");
                Console.WriteLine("1.studentlist \t 2.courselist \t 3.introducenewcourse \t 4.showFirstScreen");
                Console.WriteLine("Enter your choice ( 1 or 2 or 3 or 4 ) : ");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        showAllStudentsScreen();
                        break;
                    case 2:
                        showAllCoursesScreen();
                        break;
                    case 3:
                        introduceNewCourseScreen();
                        break;
                    case 4:
                        showFirstScreen();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please Enter the correct choice...and try again");
            }
        }
        public void showAllStudentsScreen()
        {
            AppEngine a = new AppEngine();
            a.ListOfStudents();
        }
        public void showStudentRegistrationScreen()
        {
            AppEngine a = new AppEngine();
            
            Student s = new Student();
            a.Register(s);

        }
        public void introduceNewCourseScreen()
        {
            AppEngine e = new AppEngine();
            Course c = new Course();
            e.Introduce(c);
        }
        public void showAllCoursesScreen()
        {
            AppEngine a = new AppEngine();
            a.ListOfCourses();
        }
    }
}

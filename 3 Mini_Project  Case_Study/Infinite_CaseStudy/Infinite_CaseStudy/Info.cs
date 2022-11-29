using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinite_CaseStudy
{
    class Info
    {
        public void sDisplay(Student student)
        {
            Console.WriteLine(" {0} \t {1} \t {2} ",
                student.id, student.name, student.dateofbirth.ToShortDateString());
        }

        public void cDisplay(Course course)
        {
            Console.WriteLine(" {0}    {1}     {2}   {3} Rs ",
                course.id, course.name, course.duration, course.fees);
        }

        public void eDisplay(Enroll enroll)
        {
            Console.WriteLine("Student Id: {0}", enroll.stdval.id);
            Console.WriteLine("Student Name: {0}", enroll.stdval.name);
            Console.WriteLine("Course Id: {0}", enroll.crsVal.id);
            Console.WriteLine("Course Name: {0}", enroll.crsVal.name);
            Console.WriteLine("Enrollment Date: {0}", enroll.enrollmentDate);
        }
        
    }
}

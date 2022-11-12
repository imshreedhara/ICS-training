using System;

namespace Infinite_CaseStudy_1
{
    public class Info
    {
        public void Display(Student student)
        {          
            Console.WriteLine(" {0} \t {1} \t {2} ",
                student.id,student.name,student.dateofbirth.ToShortDateString());
        }

        public void Display(Course course)
        {
            Console.WriteLine(" {0}    {1}    {2}   {3} ", 
                course.id, course.name,course.duration, course.fees);
        }
    }
}

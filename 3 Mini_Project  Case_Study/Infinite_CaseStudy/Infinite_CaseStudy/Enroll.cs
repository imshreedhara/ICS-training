using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinite_CaseStudy
{
    class Enroll
    {
        private Student student;
        private Course course;
        private DateTime EnrollmentDate;

        public Student stdval
        {
            get { return student; }
            set { student = value; }
        }
        public Course crsVal
        {
            get { return course; }
            set { course = value; }
        }
        public DateTime enrollmentDate
        {
            get { return EnrollmentDate; }
            set { EnrollmentDate = value; }
        }              
    }
}

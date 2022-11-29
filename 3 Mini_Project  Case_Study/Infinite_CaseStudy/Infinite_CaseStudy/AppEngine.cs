using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinite_CaseStudy
{
	class AppEngine
	{
		Info info = new Info();
		Student[] s1 = new Student[2];
		Course[] c1 = new Course[2];
		Enroll[] enrolls = new Enroll[2];
		

		public void Introduce(Course course)
		{
			c1[0] = new Course(course.id = 41, course.name = "CCNA", course.duration = "80 Hrs", course.fees = 40000);
			c1[1] = new Course(course.id = 42, course.name = "CCNE", course.duration = "90 Hrs", course.fees = 44000);

            Info info = new Info();

            for (int i = 0; i <= 1; i++)
            {
                info.cDisplay(c1[i]);
            }
        }

		public void Register(Student student)
		{
			student.id = 51;
			student.name = "Asha";
			student.dateofbirth = Convert.ToDateTime("09/03/1995");

			s1[0] = new Student()
			{
				id = student.id,
				name = student.name,
				dateofbirth = student.dateofbirth,
			};

			student.id = 52;
			student.name = "Anil";
			student.dateofbirth = Convert.ToDateTime("13/04/1985");

			s1[1] = new Student()
			{
				id = student.id,
				name = student.name,
				dateofbirth = student.dateofbirth,
			};

            for (int i = 0; i <= 1; i++)
            {
                info.sDisplay(s1[i]);
            }

        }

		public Student[] ListOfStudents()
		{
			//Student[] s = new Student[2];
			for (int i = 0; i <s1.Length; i++)
			{
				s1[i] = new Student()
				{
					id = s1[i].id,
					name = s1[i].name,
					dateofbirth = s1[i].dateofbirth,
				};
			}
			return s1;
		}

        public Course[] ListOfCourses()
        {
			//Course[] c = new Course[2];

			for(int i=0;i<2;i++)
            {
				c1[i] = new Course()
				{
					id = c1[i].id,
					name = c1[i].name,
					duration = c1[i].duration,
					fees = c1[i].fees,
				};				
            }
			return c1;
		}

        public void Enroll(Student student, Course course)
        {
			student.id = 51;
			student.name = "Sri Lakshmi";
			student.dateofbirth = Convert.ToDateTime("05/01/1995");

			Enroll e = new Enroll();
			e.enrollmentDate = Convert.ToDateTime(DateTime.Now);

			s1[0] = new Student()
			{
				id = student.id,
				name = student.name,
				dateofbirth = student.dateofbirth,
			};

			c1[0] = new Course(course.id = 41, course.name = "CCNA");


			enrolls[0] = new Enroll()
			{
				enrollmentDate = e.enrollmentDate,
			};
			//enrolls[0].enrollmentDate = Convert.ToDateTime(DateTime.Now);
		}

        public Enroll[] ListOfEnrollments()
        {

			for (int i = 0; i < s1.Length; i++)
			{
				s1[i] = new Student()
				{
					id = s1[i].id,
					name = s1[i].name,					
				};

				c1[i] = new Course()
				{
					id = c1[i].id,
					name = c1[i].name,					
				};

				enrolls[i] = new Enroll()
				{
					enrollmentDate = enrolls[0].enrollmentDate,

				};
			}
			return enrolls;
		}

    }
}
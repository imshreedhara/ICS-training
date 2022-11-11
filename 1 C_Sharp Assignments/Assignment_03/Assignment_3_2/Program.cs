
/*  2. Create a class called student which has data members 
 *		like rollno, name, class, Semester, branch, int[] marks = new int marks[5] (marks of 5 subjects )

	  -Pass the details of student like rollno, name, class, SEM, branch in constructor
	  -For marks write a method called GetMarks() and give marks for all 5 subjects
	  -Write a method called displayresult, which should calculate the average marks
	  -If marks of any one subject is less than 35 print result as failed
	  -If marks of all subject is >35 but average is < 50 then also print result as failed
	  -If avg > 50 then print result as passed.
	  -Write a DisplayData() method to display all values.  */


using System;

namespace Assignment_3_2
{
	class Student
	{
		public int RollNo;
		public string Name;
		public int stuClass;
		public int Semester;
		public string branch;
		public int sum;
		int[] marks = new int[5];
		int avgMarks;
		int count = 0;

		static void Main(string[] args)
		{
			Student st = new Student(12345, "Shreedhara", 12, 2, "EEE");

			Console.WriteLine("Enter the marks of all 5 subjects of the student Shreedhara :");
			st.GetMarks();
			st.DisplayResult();
			st.DisplayData();

			Console.ReadKey();
		}

		public Student(int rNo, string stName, int sClass, int sem, string branchName)
		{
			RollNo = rNo;
			Name = stName;
			stuClass = sClass;
			Semester = sem;
			branch = branchName;
		}

		public void GetMarks()   //to get the 5 subjects marks of student from d user 
		{
			for (int i = 0; i < marks.Length; i++)
			{
				marks[i] = Convert.ToInt32(Console.ReadLine());

				if (marks[i] < 35)
				{
					count++;
				}
				sum += marks[i];
			}
		}

		public void DisplayResult()     //to calculate the Avg of marks
		{
			int len = marks.Length;
			int sum = 0;

			for (int i = 0; i < marks.Length; i++)
			{
				sum += marks[i];
			}
			avgMarks = sum / len;
		}

		public void DisplayData()
		{
			Console.WriteLine("========================Student Details And Results=========================");
			Console.WriteLine("Student Name :{0}\nStudent Roll No :{1}\nStudent class :{2}\nsemester :{3}\n" +
							  "branch is :{4}", Name, RollNo, stuClass, Semester, branch);

			Console.WriteLine("total marks :{0}\n Avg Marks : {1}:", sum, avgMarks);

			if (count > 0 && avgMarks < 50)
			{
				Console.WriteLine("Student {0} got failed ", Name);
			}

			else
			{
				Console.WriteLine("Student {0} got Passed ", Name);
			}
		}
	}
}

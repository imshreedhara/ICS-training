using System;

namespace Assignment_3._1
{
	/*  2. Create a class called student which has data members like rollno, name, class, Semester, branch, int[] marks = new int marks[5] (marks of 5 subjects )

	  -Pass the details of student like rollno, name, class, SEM, branch in constructor
	  -For marks write a method called GetMarks() and give marks for all 5 subjects
	  -Write a method called displayresult, which should calculate the average marks
	  -If marks of any one subject is less than 35 print result as failed
	  -If marks of all subject is >35 but average is < 50 then also print result as failed
	  -If avg > 50 then print result as passed.
	  -Write a DisplayData() method to display all values.  */

	class Student
	{
		public int RollNo;
		public string Name;
		public int stuClass;
		public int Semester;
		public string branch;
		public sum;

		static void Main(string[] args)
		{
			Student st = new Student(12345, "shreedhara", 12, 2, "EEE");
			Console.WriteLine("Enter the marks of all 5 subjects of the student Shreedhara :");
			st.GetMarks();
			st.DisplayResult();

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

		public void GetMarks()          //to get the 5 subjects marks of student from d user 
		{
			int[] marks = new int[5];
			for (int i = 0; i < 5; i++)
			{
				marks[i] = Convert.ToInt32(Console.ReadLine());
				int sum += arr[i];//

			}

		}

		public void DisplayResult()     //to calculate d Avg of marks
		{

		}


	}
}

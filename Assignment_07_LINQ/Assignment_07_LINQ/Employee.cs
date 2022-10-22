
#region

/* 1. Create a console application and add class named Employee with following field.
           Employee Class
           EmployeeID (Integer)
           FirstName(String)
           LastName(String)
           title(String)
           DOB(Date)
           DOJ(Date)
           city(String)                       


// 2. Create a Generic List Collection empList and populate it with the following records.

/*  EmployeeID   FirstName   LastName      title             DOB                DOJ             city
     1001        Malcolm     Daruwalla    Manager         16/11/1984         08/06/2011        Mumbai
     1002        Asdin       Asdin       AsstManager      20/08/1984         07/07/2012        Mumbai
     1003        Madhavi     Oza         Consultant       14/11/1987         12/04/2015        Pune
     1004        Saba        Shaikh      SE               03/06/1990         02/02/2016        Pune
     1005        Nazia       Shaikh      SE               08/03/1991         02/02/2016        Mumbai
     1006        Amit        Pathak      Consultant       07/11/1989         08/08/2014        Chennai
     1007        Vijay       Natrajan    Consultant       02/12/1989         01/06/2015        Mumbai
     1008        Rahul       Dubey       Associate        11/11/1993         06/11/2014        Chennai
     1009        Suresh      Mistry      Associate        12/08/1992         03/12/2014        Chennai
     1010        Sumit       Shah        Manager          12/04/1991         02/01/2016        Pune             



// 3. Now once the collection is created write down and execute the LINQ queries for collection as follows :

a. Display detail of all the employee
b. Display details of all the employee whose location is not Mumbai
c. Display details of all the employee whose title is AsstManager
d. Display details of all the employee whose Last Name start with S
e. Display a list of all the employee who have joined before 1/1/2015
f. Display a list of all the employee whose date of birth is after 1/1/1990
g. Display a list of all the employee whose designation is Consultant and Associate
h. Display total number of employees
i. Display total number of employees belonging to “Chennai”
j. Display highest employee id from the list
k. Display total number of employee who have joined after 1/1/2015
l. Display total number of employee whose designation is not “Associate”
m. Display total number of employee based on city
n. Display total number of employee based on city and title
o. Display total number of employee who is youngest in the list          */

#endregion


using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_07_LINQ
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string city { get; set; }

        public static List<Employee> GetEmployee()
        {
            List<Employee> emplist = new List<Employee>
            {
                new Employee {EmployeeID=1001, FirstName = "Malcolm", LastName = "Daruwalla", title = "Manager", city = "Mumbai", DOB = new DateTime(1984/11/20), DOJ = new DateTime(2011,6,8) },
                new Employee {EmployeeID=1002, FirstName = "Asdin", LastName = "Dhalla", title = "AsstManager", city = "Mumbai", DOB=new DateTime(1984,08,20), DOJ =new DateTime(2012,7,7) },
                new Employee {EmployeeID=1003,FirstName= "Madhavi",LastName= "Oza",title ="Consultant",city= "Pune",DOB=new DateTime(1987,11,14),DOJ=new DateTime(2015,4,12) },
                new Employee {EmployeeID=1004, FirstName = "Saba", LastName = "Shaikh", title = "SE", city = "Pune", DOB =new DateTime (1990,6,3), DOJ =new DateTime(2016,2,2) },
                new Employee {EmployeeID=1005,FirstName= "Nazia", LastName = "Shaikh",title="SE",city="Mumbai",DOB=new DateTime(1991,3,8),DOJ=new DateTime(2016,2,2)},
                new Employee {EmployeeID=1006,FirstName= "Amit",LastName= "Pathak",title="Consultant",city= "Chennai",DOB=new DateTime(1989,11,7),DOJ=new DateTime(2014,8,8)},
                new Employee {EmployeeID=1007,FirstName="Vijay",LastName= "Natrajan",title="Consultant",city= "Mumbai",DOB=new DateTime(1989,12,2),DOJ=new DateTime(2015,6,1)},
                new Employee {EmployeeID=1008,FirstName= "Rahul",LastName= "Dubey",title= "Associate",city= "Chennai",DOB=new DateTime(1993,11,11),DOJ=new DateTime(2014,11,6)},
                new Employee {EmployeeID=1009,FirstName= "Suresh",LastName= "Mistry",title= "Associate",city= "Chennai",DOB=new DateTime(1992,8,12),DOJ=new DateTime(2014,12,3)},
                new Employee {EmployeeID=1010,FirstName= "Sumit",LastName="Shah",title="Manager",city= "Pune",DOB=new DateTime(1991,4,12),DOJ=new DateTime(2016,1,2) },
            };
            return emplist;
        }
    }

    class EmployeeLinqEg
    {
        static void Main(string[] args)
        {
            #region
            //a.Displaying details of all the employees

            Console.WriteLine("Employee details are : ");
            var emp = from allEmplees in Employee.GetEmployee()
                      select allEmplees;

            Console.WriteLine("Emp ID \t  FirstName \t  LastName  \t  title  \t  City  \t   DOB \t   DOJ");

            foreach (var allEmps in emp)
            {
                Console.WriteLine(allEmps.EmployeeID + "\t" + allEmps.FirstName + "\t" + allEmps.LastName + "\t" + allEmps.title + "\t\t" + allEmps.city + "\t" + allEmps.DOB.ToShortDateString() + "\t" + allEmps.DOJ.ToShortDateString());
            }
            #endregion

            #region
            //b.Displaying details of all the employee whose location is not Mumbai

            var emp1 = from mumbaiEmp in Employee.GetEmployee()
                      where mumbaiEmp.city != "Mumbai"
                      select mumbaiEmp;


            // Console.WriteLine("EmployeeID \t FirstName \t LastName \t\t title \t City \t DOB \tDOJ");
            foreach (var e1 in emp1)
            {
                //Console.WriteLine(e1.EmployeeID  + e1.FirstName + e1.LastName + e1.title + e1.city + e1.DOB.ToShortDateString() + e1.DOJ.ToShortDateString());
                Console.WriteLine("EmployeeID : {0} FirstName : {1}  LastName : {2}    title : {3}  city : {4}  DOB : {5}  DOJ : {6}", e1.EmployeeID, e1.FirstName, e1.LastName, e1.title, e1.city, e1.DOB.ToShortDateString(), e1.DOJ.ToShortDateString());
            }
            #endregion

            #region
            //c.Display details of all the employee whose title is AsstManager

           var emp2 = from assmgr in Employee.GetEmployee()
                      where assmgr.title.Equals("AsstManager")
                      select assmgr;
            foreach (var e2 in emp2)
            {
                Console.WriteLine("EmployeeID : {0} FirstName : {1}  LastName : {2}    title : {3}  city : {4}  DOB : {5}  DOJ : {6}", e2.EmployeeID, e2.FirstName, e2.LastName, e2.title, e2.city, e2.DOB.ToShortDateString(), e2.DOJ.ToShortDateString());

            }
            #endregion

            #region
            // d.Display details of all the employee whose Last Name start with S

            var emp3 = from Last_Name in Employee.GetEmployee()
                       where Last_Name.LastName.StartsWith("S")
                       select Last_Name;

            foreach (var e3 in emp3)
            {
                Console.WriteLine("EmployeeID : {0} FirstName : {1}  LastName : {2}  title : {3}  city : {4}  DOB : {5}  DOJ : {6}",
                                e3.EmployeeID, e3.FirstName, e3.LastName, e3.title, e3.city, e3.DOB.ToShortDateString(), e3.DOJ.ToShortDateString());
            }
            #endregion

            #region
            // e.Display a list of all the employee who have joined before 1 / 1 / 2015

            var emp4 = from doj in Employee.GetEmployee()
                       where doj.DOJ < DateTime.Parse("2015/01/01")
                       select doj;

            foreach (var e4 in emp4)
            {
                Console.WriteLine("EmployeeID : {0} FirstName : {1}  LastName : {2}  title : {3}  city : {4}  DOB : {5}  DOJ : {6}",
                            e4.EmployeeID, e4.FirstName, e4.LastName, e4.title, e4.city, e4.DOB.ToShortDateString(), e4.DOJ.ToShortDateString());
            }
            #endregion

            #region
            // f.Display a list of all the employee whose date of birth is after 1 / 1 / 1990

            var emp5 = from dob in Employee.GetEmployee()
                       where dob.DOB > DateTime.Parse("1990/01/01")
                       select dob;

            foreach (var e5 in emp5)
            {
                Console.WriteLine("EmployeeID : {0} FirstName : {1}  LastName : {2}  title : {3}  city : {4}  DOB : {5}",
                            e5.EmployeeID, e5.FirstName, e5.LastName, e5.title, e5.city, e5.DOB.ToShortDateString());
            }
            #endregion

            #region
            // g.Display a list of all the employee whose designation is Consultant and Associate

            var emp6 = from des in Employee.GetEmployee()
                     where des.title == "Consultant" || des.title == "Associate"
                     select des;
            
            foreach (var e6 in emp6)
            {
                Console.WriteLine("EmployeeID : {0} FirstName : {1}  LastName : {2}  title : {3}",
                                     e6.EmployeeID, e6.FirstName, e6.LastName, e6.title);
            }
            #endregion

            #region
            // h.Display total number of employees

            var emp7 = (from EmpCount in Employee.GetEmployee()
                     select EmpCount.EmployeeID).Count();
            Console.WriteLine(" The total Count of Employee is : {0}", emp7);
            #endregion

            #region
            // i.Display total number of employees belonging to “Chennai”

            var emp8 = from ChennaiEmp in Employee.GetEmployee()
                       where ChennaiEmp.city.Equals("Chennai")
                       select ChennaiEmp;

            foreach (var e8 in emp8)
            {
                Console.WriteLine("EmployeeID : {0} FirstName : {1}  LastName : {2}  title : {3}. city : {4}",
                                     e8.EmployeeID, e8.FirstName, e8.LastName, e8.title, e8.city);
            }
            #endregion

            #region
            // j.Display highest employee id from the list

            var emp9 = (from MaxEmpId in Employee.GetEmployee()
                      select MaxEmpId.EmployeeID).Max();

            Console.WriteLine("The Highest employee id from the list is : {0}", emp9);

            #endregion

            #region
            // k.Display total number of employee who have joined after 1 / 1 / 2015

            var emp10 = (from doj in Employee.GetEmployee()
                         where doj.DOJ > DateTime.Parse("01/01/2015")
                         select doj).Count();

            Console.WriteLine("The count of employees who have joined after 1/1/2015 is : {0}", emp10);

            #endregion

            #region
            // l.Display total number of employee whose designation is not “Associate”

            var emp11 = (from AssoEmp in Employee.GetEmployee()
                         where AssoEmp.title != "Associate"
                         select AssoEmp).Count();

            Console.WriteLine("total count of employees whose designation is not Associate is : {0}", emp11);
            #endregion

            #region
            // o.Display youngest employee who is  in the list

            var emp14 = (from ygEmp in Employee.GetEmployee()
                         orderby ygEmp.DOB ascending
                         select ygEmp).LastOrDefault();

            Console.WriteLine("The youngest employee  from the list is : {0} {1} DOB : {2}", emp14.FirstName, emp14.LastName, emp14.DOB.Date.ToShortDateString());
            #endregion

            #region
            // m.Display total number of employee based on city

            var emp15 = Employee.GetEmployee().GroupBy(a => a.city).OrderBy(b => b.Key);

            foreach (var e15 in emp15)
            {
                Console.WriteLine("The total count of Employees in the {0} city are : {1}", e15.Key, e15.Count());
            }
            #endregion

            #region
            // n.Display total number of employee based on city and title

            var emp16 = from countEmp in Employee.GetEmployee()
                        group countEmp by new { countEmp.city, countEmp.title } into a
                        orderby a.Key.city, a.Key.title
                        select new { city = a.Key.city, title = a.Key.title, count = a.Count() };

            foreach(var e16 in emp16)
            {
                Console.WriteLine("{0} {1} in {2} office",e16.count,e16.title,e16.city);
            }

            #endregion

            Console.ReadKey();
        }
    }
}

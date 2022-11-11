using System;
using System.Data;
using System.Data.SqlClient;

namespace Ado_CodeTest
{
    class Ado_ConnectedArch
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        public static SqlConnection getConnection()
        {
            con = new SqlConnection(@"data source=MOHL011027672\MSSQLSERVER01;" +
                                     "initial catalog=Ado_CodeTest;" +
                                     "Integrated Security=True");
            con.Open();
            return con;
        }

        public static void sp_With_Output()
        {
            con = getConnection();
            
                Console.Write("enter Emplyeee name : ");
                string empname = Console.ReadLine();

                Console.Write("enter Salary : ");
                float EmpSal = float.Parse(Console.ReadLine());

                Console.Write("Enter the type of Employee : ");
                char EmpType = char.Parse(Console.ReadLine());

                cmd = new SqlCommand();
                cmd.CommandText = "sp_Insert_Employee";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;

                SqlParameter param1 = new SqlParameter
                {
                    ParameterName = "@empname",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = empname,
                    Direction = ParameterDirection.Input
                };
                cmd.Parameters.Add(param1);

                SqlParameter param2 = new SqlParameter
                {
                    ParameterName = "@empsal",
                    SqlDbType = SqlDbType.Float,
                    Value = EmpSal,
                    Direction = ParameterDirection.Input,
                };
                cmd.Parameters.Add(param2);

                SqlParameter param3 = new SqlParameter
                {
                    ParameterName = "@emptype",
                    SqlDbType = SqlDbType.Char,
                    Value = EmpType,
                    Direction = ParameterDirection.Input,
                };
                cmd.Parameters.Add(param3);

                //adding output parameter to the procedure
                SqlParameter paramout = new SqlParameter
                {
                    ParameterName = "@empno",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output,
                };
                cmd.Parameters.Add(paramout);
                cmd.ExecuteNonQuery();
                Console.WriteLine("The newely generated Employee Id is :" +
                                   paramout.Value.ToString()); 
            

        }

        public static void DisplayEmployee()
        {
            con = getConnection();
            try
            {

                cmd = new SqlCommand("select * from Code_Employee");
                cmd.Connection = con;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2] + " " + dr[3]);



                }
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
        }


        static void Main(string[] args)
        {
            sp_With_Output();
           
            Console.ReadKey();
        }
    }
}

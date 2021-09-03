using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace EmployeePayRollAdo
{
    public class EmployeePayRoll
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EmployeePayrollADO";
        public static List<Employee> EmployeeList = new List<Employee>();
        SqlConnection sqlConnection = new SqlConnection(connectionString);

        public List<Employee> GetAllEmployeeDetails()
        {
            SqlCommand com = new SqlCommand("spGetAllEmployeeDetails", sqlConnection);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();

            sqlConnection.Open();
            da.Fill(dt);
            sqlConnection.Close();
            foreach (DataRow dr in dt.Rows)
            {
                EmployeeList.Add(

                    new Employee
                    {
                        ID = Convert.ToInt32(dr["Id"]),
                        Name = Convert.ToString(dr["Name"]),
                        Gender = Convert.ToChar(dr["Gender"]),
                        Department = Convert.ToString(dr["Department"]),
                        Salary = Convert.ToString(dr["Salary"]),
                        StartDate = Convert.ToString(dr["StartDate"]),
                        BasicPay = Convert.ToDouble(dr["BasicPay"]),
                        Deduction = Convert.ToDouble(dr["Deduction"]),
                        TaxabalePay = Convert.ToDouble(dr["TaxablePay"]),
                        IncomeTax = Convert.ToDouble(dr["IncomeTax"]),
                        NetPay = Convert.ToInt32(dr["NetPay"]),

                    });

            }
            return EmployeeList;
        }
        public void Display()
        {
            foreach (var item in EmployeeList)
            {
                Console.WriteLine("ID : " + item.ID);
                Console.WriteLine("Name  : " + item.Name);
                Console.WriteLine("Gender  : " + item.Gender);
                Console.WriteLine("Department  : " + item.Department);
                Console.WriteLine("Salary : " + item.Salary);
                Console.WriteLine("StartDate  : " + item.StartDate);
                Console.WriteLine("BasicPay  : " + item.BasicPay);
                Console.WriteLine("Deduction  : " + item.Deduction);
                Console.WriteLine("TaxablePay  : " + item.TaxabalePay);
                Console.WriteLine("IncomeTax  : " + item.IncomeTax);
                Console.WriteLine("NetPay  : " + item.NetPay);
            }
        }
    }
}


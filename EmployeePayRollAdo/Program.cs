using System;

namespace EmployeePayRollAdo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Pay Roll ADO");
            EmployeePayRoll employeePayRoll = new EmployeePayRoll();
            employeePayRoll.GetAllEmployeeDetails();
            employeePayRoll.Display();
        }
    }
}

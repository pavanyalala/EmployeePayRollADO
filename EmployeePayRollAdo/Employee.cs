using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayRollAdo
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public char Gender { get; set; }
        public string Department { get; set; }
        public string Salary { get; set; }
        public string StartDate { get; set; }
        public double BasicPay { get; set; }
        public double Deduction { get; set; }
        public double TaxabalePay { get; set; }
        public double IncomeTax { get; set; }
        public double NetPay { get; set; }
    }
}

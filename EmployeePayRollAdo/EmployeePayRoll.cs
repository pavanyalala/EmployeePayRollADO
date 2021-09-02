using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EmployeePayRollAdo
{
    public class EmployeePayRoll
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EmployeePayRollADO";
        SqlConnection sqlConnection = new SqlConnection(connectionString);
    }
}

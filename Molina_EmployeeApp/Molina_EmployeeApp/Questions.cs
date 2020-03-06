using System;
using static System.Console;
namespace Molina_EmployeeApp
{
    public class Questions
    {
        public Questions()
        {
        }
        public string EmployeeName(string which)
        {
            Write("{0,-56}", "Please enter the employee's " + which + " name:");
            return ReadLine();
        }

        public double EmployeeTotalSales()
        {
            double totalSales;

            Write("{0,-56}", "Please enter the employee's total sales for the month:");
            totalSales = double.Parse(ReadLine());

            return totalSales;
        }
    }
}

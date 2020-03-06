using System;
using static System.Console;

namespace Molina_EmployeeApp
{
    class EmployeeApp
    {
        static void Main()
        {
            string fName;
            string lName;
            double sales;

            Employee emp;
            Questions q = new Questions();

            WriteLine("******************************************************\n");
            WriteLine("{0,-15}Barry Molina", "Name:");
            WriteLine("{0,-15}ITDEV-115-200", "Course:");
            WriteLine("{0,-15}J. Christie", "Instructor:");
            WriteLine("{0,-15}Employee Payroll Assignment", "Assignment:");
            WriteLine("{0,-15}2/6/2020", "Date:");
            WriteLine("\n******************************************************\n\n");

            fName = q.EmployeeName("first");
            lName = q.EmployeeName("last");
            sales = q.EmployeeTotalSales();

            emp = new Employee(fName, lName, sales);
            emp.CalculateWithholdings();

            WriteLine("\n\n\n\nName: " + emp.Name + "\n");
            WriteLine("{0,-32}{1:C2}", "Employee Gross Income:", 
                        emp.CalculateCommissionIncome());
            WriteLine("{0,-32}{1:C2}", "Federal Tax Withheld:", 
                        emp.Federal);
            WriteLine("{0,-32}{1:C2}", "Social Security Tax Withheld:", 
                        emp.SS);
            WriteLine("{0,-32}{1:C2}", "Retirement Contributions:", 
                        emp.Retirement);
            WriteLine();
            WriteLine("{0,-32}{1:C2}", "Employee Net Pay:", 
                        emp.CalculateCommissionIncome() 
                        - emp.Federal - emp.SS - emp.Retirement);
            ReadKey();
        }
    }
}

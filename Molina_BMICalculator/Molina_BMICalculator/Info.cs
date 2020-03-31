using System;
using static System.Console;
namespace Molina_BMICalculator
{
    public class Info
    {
        public void AssignementInfo()
        {
            WriteLine("******************************************************\n");
            WriteLine("{0,-15}Barry Molina", "Name:");
            WriteLine("{0,-15}ITDEV-115-200", "Course:");
            WriteLine("{0,-15}J. Christie", "Instructor:");
            WriteLine("{0,-15}Assignment #6 - Farmer Game", "Assignment:");
            WriteLine("{0,-15}3/26/2020", "Date:");
            WriteLine("\n******************************************************\n");
            WriteLine("Press any key to continue.");
            ReadKey();
            Clear();
        }
    }
}

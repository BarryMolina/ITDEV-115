using System;
using static System.Console;
namespace Molina_ElectionResultsApp
{
    public class Info
    {
        public Info()
        {
        }

        public void DisplayInfo()
        { 
            Clear();
            WriteLine("******************************************************\n");
            WriteLine("{0,-15}Barry Molina", "Name:");
            WriteLine("{0,-15}ITDEV-115-200", "Course:");
            WriteLine("{0,-15}J. Christie", "Instructor:");
            WriteLine("{0,-15}Mid-Term Election Program", "Assignment:");
            WriteLine("{0,-15}3/7/2020", "Date:");
            WriteLine("\n******************************************************");
        }
    }
}

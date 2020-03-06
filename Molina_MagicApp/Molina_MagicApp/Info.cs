using System;
using static System.Console;

namespace Molina_MagicApp
{
    public class Info
    {
        public void AssignementInfo()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            WriteLine("*******************************************************************************\n");
            WriteLine("{0,-15}Barry Molina", "Name:");
            WriteLine("{0,-15}ITDEV-115-200", "Course:");
            WriteLine("{0,-15}J. Christie", "Instructor:");
            WriteLine("{0,-15}Magic PC Example", "Assignment:");
            WriteLine("{0,-15}2/22/2020", "Date:");
            WriteLine("\n*******************************************************************************");
            Console.ResetColor();
        }
    }
}


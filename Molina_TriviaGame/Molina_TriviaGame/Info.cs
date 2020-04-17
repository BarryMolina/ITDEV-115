using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Molina_TriviaGame
{
    class Info
    {
        public void AssignmentInfo()
        {
            Clear();
            ForegroundColor = ConsoleColor.White;
            WriteLine("**********************************************" +
                "*********************************\n");
            WriteLine("{0,-15}Barry Molina", "Name:");
            WriteLine("{0,-15}ITDEV-115-200", "Course:");
            WriteLine("{0,-15}J. Christie", "Instructor:");
            WriteLine("{0,-15}Assignment #6 - Farmer Game", "Assignment:");
            WriteLine("{0,-15}4/3/2020", "Date:");
            WriteLine("\n**********************************************" +
                "*********************************\n");
            ResetColor();
        }
    }
}

using System;
using static System.Console;
namespace FarmerGame
{
    public class Info
    {
        public void AssignmentInfo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            WriteLine("******************************************************\n");
            WriteLine("{0,-15}Barry Molina", "Name:");
            WriteLine("{0,-15}ITDEV-115-200", "Course:");
            WriteLine("{0,-15}J. Christie", "Instructor:");
            WriteLine("{0,-15}Assignment #6 - Farmer Game", "Assignment:");
            WriteLine("{0,-15}3/26/2020", "Date:");
            WriteLine("\n******************************************************\n");

            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("\n\n\tThis is the Farmer Game. The object of the game" +
                "\n\tis to get the farmer, fox, chicken, and grain to the other" +
                "\n\tside of the river. But hold on, not so fast. If the farmer" +
                "\n\tleaves the chicken and grain on either side of the river alone," +
                "\n\tthe chicke will eat the grain and that is not good. If the" +
                "\n\tfarmer leaves the fox and chicken on any side of the river alone," +
                "\n\tthe fox will eat the chicken. This is also not good. In eather case" +
                "\n\tyou lose the game. If you get the farmer, the chicken," +
                "\n\tthe fox, and the grain safely across the river and intact, you win\n\n\n");

            Console.ForegroundColor = ConsoleColor.White;
            WriteLine("Press any key when you are ready to start this though provoking game");
            ReadKey();
            Console.ResetColor();
            Clear();
        }
    }
}

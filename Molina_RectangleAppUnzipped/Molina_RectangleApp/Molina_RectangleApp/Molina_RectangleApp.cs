using System;
using static System.Console;

namespace Molina_RectangleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dimensions dimensions = new Dimensions();

            AssignementInfo();
            Directions();

            dimensions.InputHeight();
            dimensions.InputWidth();

            WriteLine("\nThe area of the rectangle is " + dimensions.CalculateArea());
            WriteLine("The perimeter of the rectangle is {0:f1}", dimensions.CalculatePerimeter());

            ReadKey();
        }
        static void Directions()
        {
            WriteLine("This program will calculate the area and the perimeter of a rectangle.");
            WriteLine("All you need to do is enter the rectangle's height and width.\n");
        }

        static void AssignementInfo()
        {
            WriteLine("******************************************************\n");
            WriteLine("{0,-15}Barry Molina", "Name:");
            WriteLine("{0,-15}ITDEV-115-200", "Course:");
            WriteLine("{0,-15}J. Christie", "Instructor:");
            WriteLine("{0,-15}Rectangle Assignment", "Assignment:");
            WriteLine("{0,-15}1/28/2020", "Date:");
            WriteLine("\n******************************************************\n\n");
        }
    }
}

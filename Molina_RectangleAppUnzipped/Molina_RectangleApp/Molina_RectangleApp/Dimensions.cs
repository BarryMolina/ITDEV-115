using System;
using static System.Console;

namespace Molina_RectangleApp
{
    public class Dimensions
    {
        private double height;
        private double width;

        public void InputHeight()
        {
            Write("\nPlease enter the rectangle's height in inches: ");
            height = double.Parse(ReadLine());
        }

        public void InputWidth()
        { 
            Write("Please enter the rectangle's width in inches: ");
            width = double.Parse(ReadLine());
        }

        public double CalculateArea()
        {
            return height * width;
        }

        public double CalculatePerimeter()
        {
            return 2 * height + 2 * width;
        }
    }
}

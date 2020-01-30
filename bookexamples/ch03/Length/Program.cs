using System;
using static System.Console;

namespace Length
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputValue;
            int feet, inches;

            Write("Enter the Length in feet: ");
            inputValue = ReadLine();
            feet = int.Parse(inputValue);
            Write("Enter the Length in inches: ");
            inputValue = ReadLine();
            inches = int.Parse(inputValue);
            
            Write("Result: {0:f2}", (feet + (double) inches / 12));
        }
    }
}

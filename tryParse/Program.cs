using System;
using static System.Console;

namespace tryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            int integerValue;
            string inStringValue;
            Write("Enter an integer value. ");
            inStringValue = ReadLine();
            while (int.TryParse(inStringValue, out integerValue) == false)
            {
                WriteLine("Invalid input");
                Write("Please re-enter an integer value. ");
                inStringValue = ReadLine();
            }
            WriteLine("Valid value entered: " + integerValue);

        }
    }
}

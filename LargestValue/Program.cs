using System;
using static System.Console;

namespace LargestValue
{
    class LargestValue
    {
        static void Main(string[] args)
        {
            int value1,
                value2,
                largestOne;
            InputValues(out value1, out value2);
            largestOne = DetermineLargest(value1, value2);
            PrintResults(largestOne);
            ReadKey();
        }
        public static void InputValues(out int v1, out int v2)
        {
            string inValue;
            Write("Enter the first value: ");
            inValue = ReadLine();
            if (int.TryParse(inValue, out v1) == false)
            {
                WriteLine("Did not input a valid integer - 0 stored in v1");
            }
            Write("Enter the second value: ");
            inValue = ReadLine();
            if (int.TryParse(inValue, out v2) == false)
            {
                WriteLine("Did not input a valid integer - 0 stored in v2");
            }
        }
        public static int DetermineLargest(int value1, int value2)
        {
            int largestOne;

            if (value1 > value2)
            {
                largestOne = value1;
            }
            else
            {
                largestOne = value2;
            }
            return largestOne;
        }
        public static void PrintResults(int largestOne)
        {
            WriteLine();
            WriteLine("The largest value entered was " + largestOne);
            WriteLine("Its square root is {0:f2}", Math.Sqrt(largestOne));
            ReadKey();
        }
    }
}

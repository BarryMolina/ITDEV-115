using System;
using static System.Console;

namespace VaryingArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayItems(1, 2, 3, 5);
            int[] anArray = new int[] {100, 200, 300, 400, 500};

            DisplayItems(anArray);
            DisplayItems(1500, anArray[1] * anArray[2]);
            ReadKey();
        }
        public static void DisplayItems(params int[] item)
        {
            for (int i = 0; i < item.Length; i++)
            {
                Write(item[i] + "\t");
            }
            WriteLine();
        }
    }
}

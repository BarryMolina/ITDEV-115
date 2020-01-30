using System;
using static System.Console;

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int testValue = 1;
            WriteLine("Original Value: {0} ", testValue);

            TestDefault(testValue);
            WriteLine("Upon return from TestDefault Value: {0}", testValue);

            WriteLine();
            WriteLine("Original Value: {0}", testValue);

            TestRef(ref testValue);
            WriteLine("Upon return from TestRef Value: {0}", testValue);
                    
            WriteLine();

            int testValue2;

            //WriteLine("Original Value: {0}", testValue2);
            //WriteLine();

            TestOut(out testValue2);
            WriteLine("Upon return from TestOut Value: {0}", testValue2);

            ReadKey();
        }

        static void TestDefault(int aValue)
        {
            aValue = 111;
            WriteLine("Inside TestDefault - Value: {0} ", aValue);
        }
        static void TestRef(ref int aValue)
        {
            aValue = 333;
            WriteLine("Inside TestRef - Value: {0} ", aValue);
        }
        static void TestOut(out int aValue)
        {
            aValue = 222;
            WriteLine("Inside TestOut - Value: {0} ", aValue);
        }
    }
}

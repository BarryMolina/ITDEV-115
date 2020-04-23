using System;
using static System.Console;

namespace Molina_TestOfCustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            double value1 = 0, value2 = 0, answer;

            try
            {
                answer = GetResult(value1, value2);
            }
            catch (FloatingPtDivisionException excepObj)
            {
                Error.WriteLine(excepObj.Message);
            }
            catch
            {
                Error.WriteLine("Something else happened.");
            }
            ReadKey();
        }

        static double GetResult(double value1, double value2)
        {
            if (value2 < 0.0000001)
            {
                FloatingPtDivisionException exepObj = new FloatingPtDivisionException(
                                                            "Exception type: Floating-point division by zero.");
                throw exepObj;
            }

            return value1 / value2;
        }
    }
}

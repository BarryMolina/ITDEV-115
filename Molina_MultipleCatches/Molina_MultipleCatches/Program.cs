using System;
using static System.Console;

namespace Molina_MultipleCatches
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] examScore;
            int totalScores = 0, countOfScores = 0;
            string inValue;
            double averageTestScore;

            try
            {
                Write("How many scores will you enter?");
                inValue = ReadLine();
                countOfScores = int.Parse(inValue);
                examScore = new int[countOfScores];

                for (int index=0; index < countOfScores; index++)
                {
                    Write("Enter score {0}: ", index + 1);
                    inValue = ReadLine();
                    examScore[index] = int.Parse(inValue);
                    totalScores += examScore[index];
                }

                averageTestScore = totalScores / countOfScores;
                WriteLine("Average is {0}", averageTestScore);
            }
            catch (FormatException e)
            {
                Error.WriteLine("Problem with one of the operands - Cannot compute average!");
                Error.WriteLine("Exception type: {0}", e.Message);
            }
            catch (Exception e) when (countOfScores == 0)
            {
                Error.WriteLine("No scores entered - Division by zero avoided!");
                Error.WriteLine("Exception type: {0}", e.Message);
            }
            catch (DivideByZeroException e)
            {
                Error.WriteLine("No scores were entered - Cannot compute average!");
                Error.WriteLine("Exception type: {0}", e.Message);
            }
            catch (ArithmeticException e)
            {
                Error.WriteLine("Error in your arithmetic or casting.");
                Error.WriteLine("Exception type: {0}", e.Message);
            }
            catch (Exception e) 
            {
                Error.WriteLine("Any other problem - Cannot compute average!");
                Error.WriteLine("Exception type: {0}", e.Message);
            }
            finally
            {
                WriteLine("...\n...\n...\n Terminated Normally!!!");
            }
            ReadKey();


        }
    }
}

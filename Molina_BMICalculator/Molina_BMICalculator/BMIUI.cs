using System;
using static System.Console;

namespace Molina_BMICalculator
{
    public class BMIUI
    {
        public void DisplayResults(int height, int weight, 
                                    double bmi, string status)
        {
            WriteLine("\n\nFor your height of {0} inches and your weight of {1} " +
                    "pounds,\nyour BMI is {2:f3} which gives you a weight status" +
                    " of {3}.", height, weight, bmi, status);
        }

        public void RequestUserData(out int height, out int weight)
        {
            Write("\n\nPlease enter your height in inches: ");
            height = int.Parse(ReadLine());

            Write("Please enter your weight in pounds: ");
            weight = int.Parse(ReadLine());
        }

        public void UserDirections()
        {
            WriteLine("\n\nThis program will calculate your Body Mass Index (BMI)"
                + "\nusing your height and weight");
        }
    }
}

using System;
using static System.Console;

namespace Molina_BMICalculator
{
    class Molina_BMICalculator
    {
        static void Main(string[] args)
        {
            BMIUI ui = new BMIUI();
            Info i = new Info();
            BMI bmi;
            int height,
                weight;

            i.AssignementInfo();

            ui.UserDirections();

            ui.RequestUserData(out height, out weight);

            bmi = new BMI(height, weight);

            bmi.CalculateBMI();

            ui.DisplayResults(height, weight, bmi.BodyMassIndex,
                            bmi.ObtainWeightStatus());
            ReadKey();
        }
    }
}




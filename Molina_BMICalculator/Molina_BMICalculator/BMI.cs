using System;
namespace Molina_BMICalculator
{
    public class BMI
    {
        private double bodyMassIndex;
        private int heightInInches;
        private int weightInPounds;

        public BMI()
        {
        }

        public BMI(int height, int weight)
        {
            heightInInches = height;
            weightInPounds = weight;
        }

        public double BodyMassIndex
        { 
            get
            {
                return bodyMassIndex;
            }
        }
        public int HeightInInches
        { 
            get
            {
                return heightInInches;
            }
            set
            {
                heightInInches = value;
            }
        }
        public int WeightInPounds
        { 
            get
            {
                return weightInPounds;
            }
            set
            {
                weightInPounds = value;
            }
        }

        public void CalculateBMI()
        {
            bodyMassIndex = ((double) weightInPounds / (heightInInches * heightInInches))
                            * 703.0;
        }

        public string ObtainWeightStatus()
        {
            string weightStatus;

            if (bodyMassIndex < 18.5)
                weightStatus = "underweight";
            else if (bodyMassIndex < 25)
                weightStatus = "normal";
            else if (bodyMassIndex < 30)
                weightStatus = "overweight";
            else
                weightStatus = "obese";

            return weightStatus;
        }
    }
}

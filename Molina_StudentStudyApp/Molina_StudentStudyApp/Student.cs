using System;
namespace Molina_StudentStudyApp
{
    public class Student
    {
        private double[] hours = new double[7];
        private int id;
        private string name;

        public int ID { get; set; }
        public string Name { get; set; }

        public double CalculateAvg()
        {
            double sum = 0;
            for (int x = 0; x < hours.Length; x++)
            {
                sum += hours[x];
            }
            return sum / hours.Length;
        }

        public void EnterHours(int i, double value)
        {
            hours[i] = value;
        }

        public double[] GetNumberHours()
        {
            return hours;
        }

        public Student()
        {
        }
    }
}

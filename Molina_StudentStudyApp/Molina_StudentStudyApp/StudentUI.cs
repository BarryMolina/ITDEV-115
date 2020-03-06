using System;
using static System.Console;
namespace Molina_StudentStudyApp
{
    public class StudentUI
    {
        string[] days = new string[] {"Sunday", "Monday", "Tuesday", "Wednesday",
        "Thursday", "Friday", "Saturday"};
       
        public void DisplayAvg()
        { 
        }

        public void DisplayData(Student s)
        {
            Clear();
            WriteLine("Name: " + s.Name);
            WriteLine("ID: " + s.ID);
            WriteLine("\n\nThe number of hours of study that you did" 
                + " during the week are as follows:");
            for (int i = 0; i < days.Length; i++)
            {
                WriteLine("\t{0,-9}:\t{1:F2}", days[i], s.GetNumberHours()[i]);
            }
            WriteLine("\n\nThe average number of hours studied per day was " + 
                "{0:F2}", s.CalculateAvg());

            ReadKey();
                     
        }

        public void FillHours(Student s)
        { 
            for (int i = 0; i < days.Length; i++)
            {
                Write("{0,-55}:\t", "Enter the number of hours that you studied on " +
                    days[i]);
                s.EnterHours(i, double.Parse(ReadLine()));
            }
        }

        public string GetName()
        {
            Write("Please enter your name:\t\t");
            return ReadLine();
        }

        public int GetStudentID()
        { 
            Write("Please enter your student id:\t");
            return int.Parse(ReadLine());
        }
    }
}

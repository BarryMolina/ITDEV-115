using System;
using static System.Console;

namespace StudentApp
{
    class StudentApp
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.FirstName = AskName("First");
            s1.LastName = AskName("Last");
            s1.Number = AskNumber();
            s1.Major = AskMajor(s1.FirstName);
            s1.Score1 = AskScore(1);
            s1.Score2 = AskScore(2);
            s1.Score3 = AskScore(3);

            Clear();
            WriteLine("First Student");
            WriteLine(s1.ToString());

            Student s2 = new Student("2345");
            s2.Score1 = 95;
            s2.Score2 = 62;
            s2.Score3 = 87;

            WriteLine("\n\nSecond Student");
            WriteLine("Student Number: " + s2.Number + "\nAverage: {0:F1}",
                    s2.CalculateAverage());

            Student s3 = new Student("5432", "Randolph", "Wonder");
            s3.Major = "Math";
            s3.Score1 = 95;
            s3.Score2 = 87;
            s3.Score3 = 72;

            WriteLine("\n\nThird Student");
            WriteLine(s3);
        
            Student s4 = new Student("1234", "Maria", "Smith", 97, 75, 87, "CS");

            WriteLine("\n\nLast Student");
            WriteLine("Student Name: " + s4.FirstName + " " + s4.LastName +
                      "\nStudent Number: " + s4.Number +
                      "\nMajor: " + s4.Major + 
                      "\nExam Score 1: " + s4.Score1 +
                      "\nExam Score2: " + s4.Score2 +
                      "\nExam Score3: " + s4.Score3 +
                      "\nExam Average: " + s4.CalculateAverage().ToString("F1"));
            ReadKey();
        }

        static int AskScore(int score)
        {
            string input;
            int scoreInt;
            Write("Enter a value for Score {0}: ", score);
            input = ReadLine();
            scoreInt = int.Parse(input);
            return scoreInt;
        }

        static string AskName(string name)
        {
            string input;
            Write("enter student {0} name: ", name);
            input = ReadLine();
            return input;
        }

        static string AskMajor(string name)
        {
            string input;
            Write("Enter {0}\'s Major: ", name);
            input = ReadLine();
            return input;
        }

        static string AskNumber()
        {
            string input;
            Write("Enter Student Number: ");
            input = ReadLine();
            return input;
        }
    }
}

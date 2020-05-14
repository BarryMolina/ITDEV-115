using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molina_StudentList
{
    class GradesUI
    {
        StudentS myStudentS;

        public void MainMethod()
        {
            string msg;
            myStudentS = new StudentS();
            msg = myStudentS.PopulateStudents("grades.txt");
            if (msg == "")
            {
                DisplayInfo();
            }
            else
            {
                Console.WriteLine(msg);
            }
            Console.ReadKey();
        }

        void DisplayInfo()
        {
            Console.WriteLine("Student id\tLast Name\tAverage  \tGrade");

            for (int index = 0; index < myStudentS.ListLength; index++)
            {

                Console.WriteLine(" {0} \t {1}    \t {2}    \t {3}", myStudentS.StudentID(index), myStudentS.StudentLastName(index), myStudentS.StudentAverage(index), myStudentS.StudentGrade(index));
            }
        }
    }
}

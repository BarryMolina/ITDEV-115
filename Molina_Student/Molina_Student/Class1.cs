using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonNameSpace;
using Molina_ITravelerNameSpace;

namespace Molina_Student
{
    public class Student : Person, ITraveler
    {
        private string major;
        private string studentID;

        public Student() { }

        public Student(string id, string fname, string lname, string major, string studentID) 
            : base(id, lname, fname)
        {
            this.major = major;
            this.studentID = studentID;
        }
        public string Major { 
            get { return major; } 
            set { major = value; } 
        }
        public string StudentID { 
            get { return studentID; } 
            set { studentID = value; } 
        }

        public override int GetSleepAmt()
        {
            return 6;
        }

        public override string GetExcerciseHabits()
        {
            return "Excercise daily";
        }

        public string GetDestination()
        {
            return "Home";
        }

        public string GetStartLocation()
        {
            return "School";
        }
        
        public double DetermineMiles()
        {
            return 75.0;
        }
    }
}

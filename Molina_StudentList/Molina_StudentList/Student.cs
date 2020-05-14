using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/******************************
 * Student: Your Name
 * Purpose: Student Grades -- Arrays
 ******************************/

namespace Molina_StudentList
{
    
    class Student
    {
        //data member
        string nameFirst;
        string nameLast;
        string studentID;
        List<int> earned;
        List<int> possible;
        float average;
        string letterGrade;

        public Student() //default constructor
        {
            studentID = null;
            earned = new List<int>();
            possible = new List<int>();
        }
        public Student(string id)  //overloaded constructor
        {
            studentID = id;
            nameFirst = null;
            nameLast = null;
            earned = new List<int>();
            possible = new List<int>();
        }
        public Student(string id, string first, string last)  //overloaded constructor
        {
            nameFirst = first;
            nameLast = last;
            studentID = id;
            earned = new List<int>();
            possible = new List<int>();
        }
        
        public void EnterGrade(int earnedValue, int possValue)
        {
            earned.Add(earnedValue);
            possible.Add(possValue);
        }
        public float Average
        {
            get { return average; }
        }
        public string LetterGrade
        {
            get { return letterGrade; }
        }
        public string ID
        {
            get { return studentID; }
        }
        //accessor mutators //properties
        public string NameFirst
        {
            get  //accessor - getters
            {
                return nameFirst;
            }
            set  //mutator - setter
            {
                nameFirst = value;
            }
        }
        public string NameLast
        {
            get  //accessor - getters
            {
                return nameLast;
            }
            set  //mutator - setter
            {
                nameLast = value;
            }
        }
           

       public void CalGrade()
       {
           int totalEarned = 0;
           int totalPossible = 0;
             
           foreach (int item in earned)
               totalEarned += item;

           foreach (int item in possible)
               totalPossible += item;

           average = (float)totalEarned / totalPossible;  //you could think that this is stored in class Level but not.
           average = (float)Math.Round(average, 2);

           
           if (average >= .90 )
               letterGrade = "A";

           if (average >= .80 && average < .90)
               letterGrade = "B";

           if (average >= .70 && average < .80)
               letterGrade = "C";

           if (average >= .60 && average < .70)
               letterGrade = "D";

           if (average < .60)
               letterGrade = "U";

       }
    }
}

using static System.Console;

namespace StudentApp
{
    public class Student
    {
        private string number;
        private string firstName;
        private string lastName;
        private int score1;
        private int score2;
        private int score3;
        private string major;

        public Student()
        {
        }

        public Student(string sID)
        {
            number = sID;
        }
        
        public Student(string sID, string lName, string fName)
        {
            number = sID;
            lastName = lName;
            firstName = fName;
        }

        public Student(string sID, string lName, string fName, 
                        int s1, int s2, int s3, string maj)
        {
            number = sID;
            lastName = lName;
            firstName = fName;
            score1 = s1;
            score2 = s2;
            score3 = s3;
            major = maj;
        }

        public string LastName
        {
            get 
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string FirstName
        {
            get 
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string Number
        {
            get 
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
        public string Major
        {
            get 
            {
                return major;
            }
            set
            {
                major = value;
            }
        }
        public int Score1
        {
            get 
            {
                return score1;
            }
            set
            {
                score1 = value;
            }
        }
        public int Score2
        {
            get 
            {
                return score2;
            }
            set
            {
                score2 = value;
            }
        }
        public int Score3
        {
            get 
            {
                return score3;
            }
            set
            {
                score3 = value;
            }
        }
        public double CalculateAverage()
        {
            return (score1 + score2 + score3) / 3.0;
        }

        public override string ToString()
        {
            return "Name: " + firstName + " " + lastName + "\nMajor: " +
                major + "\nScore Average: " +
                CalculateAverage().ToString("F2");
        }
    }
}

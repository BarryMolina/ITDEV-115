using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonNameSpace
{
    public abstract class Person
    {
        private string idNumber;
        private string lastName;
        private string firstName;
        private int age;


        public Person()
        {

        }
        public Person(string idNumber, string lastName, string firstName, int age)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.age = age;
        }
        public Person(string idNumber)
        {
            this.idNumber = idNumber;
        }
        public Person(string idNumber, string lastName, string firstName)
        {
            this.idNumber = idNumber;
            this.lastName = lastName;
            this.firstName = firstName;
        }

        public string IdNumber { get { return idNumber; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public int Age { get { return age; } set { age = value; } }

        public override string ToString()
        {
            return firstName + " " + lastName;
        }

        public virtual int GetSleepAmt()
        {
            return 8;
        }

        public abstract string GetExcerciseHabits();

    }
}

using System;
namespace Molina_EmployeeApp
{
    public class Employee
    {
        const double COMMISSIONINCOME = 7.0;
        const double FEDERALTAX = 18.0;
        const double SOCIALSECURITY = 6.0;

        private string firstName;
        private string lastName;

        private double retirementContribution = 10.0;
        private double federal;
        private double retirement;
        private double sales;
        private double ss;

        public Employee()
        {
        }

        public Employee(string fName, string lName, double salesAmount)
        {
            firstName = fName;
            lastName = lName;
            sales = salesAmount;
        }

        public double Federal
        { 
            get
            {
                return federal;
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

        public string Name
        {
            get
            {
                return firstName + " " + lastName;
            }
        }

        public double Retirement
        { 
            get
            {
                return retirement;
            }
        }

        public double Sales
        { 
            get
            {
                return sales;
            }
            set
            {
                sales = value;
            }
        }

        public double SS
        { 
            get
            {
                return ss;
            }
        }

        public double CalculateCommissionIncome()
        {
            return sales * COMMISSIONINCOME / 100;
        }

        public void CalculateFederal()
        {
            federal = CalculateCommissionIncome() * FEDERALTAX / 100;
        }

        public void CalculateRetirement()
        { 
            retirement = CalculateCommissionIncome() * retirementContribution / 100;
        }

        public void CalculateSS()
        { 
            ss = CalculateCommissionIncome() * SOCIALSECURITY / 100;
        }

        public void CalculateWithholdings()
        {
            CalculateFederal();
            CalculateRetirement();
            CalculateSS();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Molina_Assignment11
{
    class Contact
    {
        private string address;
        private string city;
        private string emailAddress;
        private string firstName;
        private string lastName;
        private string phone;
        private string state;
        private string zipCode;

        public Contact(string address, string city, string emailAddress, string firstName, string lastName, string phone, string state, string zipCode)
        {
            this.address = address;
            this.city = city;
            this.emailAddress = emailAddress;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
            this.state = state;
            this.zipCode = zipCode;
        }

        public string Address
        {
            get { return address; }
        }
        public string City
        {
            get { return city; }
        }
        public string EmailAddress
        {
            get { return emailAddress; }
        }
        public string FirstName
        {
            get { return firstName; }
        }
        public string LastName
        {
            get { return lastName; }
        }
        public string Phone
        {
            get { return phone; }
        }
        public string State
        {
            get { return state; }
        }
        public string ZipCode
        {
            get { return zipCode; }
        }


    }
}

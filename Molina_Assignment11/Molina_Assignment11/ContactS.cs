using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Molina_Assignment11
{
    class ContactS
    {
        private string fileName = "addresses.txt";
        private Contact[] myContacts;
        public static int NO_OF_CONTACTS = 4;

        public ContactS()
        {
            myContacts = new Contact[NO_OF_CONTACTS];
        }
        public string GetAddress(int idx)
        {
            return myContacts[idx].Address;
        }
        public string GetCity(int idx)
        {
            return myContacts[idx].City;
        }
        public string GetEmail(int idx)
        {
            return myContacts[idx].EmailAddress;
        }
        public string GetFirstName(int idx)
        {
            return myContacts[idx].FirstName;
        }
        public string GetLastName(int idx)
        {
            return myContacts[idx].LastName;
        }
        public string GetPhone(int idx)
        {
            return myContacts[idx].Phone;
        }
        public string GetState(int idx)
        {
            return myContacts[idx].State;
        }
        public string GetZip(int idx)
        {
            return myContacts[idx].ZipCode;
        }

        public void ReadContacts()
        {
            string address;
            string city;
            string email;
            string fName;
            string lName;
            string phone;
            string state;
            string zip;
            StreamReader reader = new StreamReader(fileName);

            for (int i = 0; i < myContacts.Length; i++)
            {
                fName = reader.ReadLine();
                lName = reader.ReadLine();
                address = reader.ReadLine();
                city = reader.ReadLine();
                state = reader.ReadLine();
                zip = reader.ReadLine();
                phone = reader.ReadLine();
                email = reader.ReadLine();

                myContacts[i] = new Contact(address, city, email, fName, lName, phone, state, zip);
            }
        }
    }
}

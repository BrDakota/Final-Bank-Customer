using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatt_Bank_Finals
{
    internal class Person
    {
        // --------------- Properties ---------------
        string firstName;
        string lastName;
        string address;
        string email;

        // --------------- Constructors ---------------
        public Person()
        {
            firstName = "";
            lastName = "";
            address = "";
            email = "";
        }
        public Person(string firstName, string lastName, string address, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.email = email;
        }

        // --------------- Get and Set ---------------
        public string GetFirstName() { return firstName; }
        public string GetLastName() { return lastName; }
        public string GetAddress() { return address; }
        public string GetEmail() { return email; }

        public void SetFirstName(string firstName) { this.firstName = firstName; }
        public void SetLastName(string lastName) { this.lastName = lastName; }
        public void SetAddress(string address) { this.address = address; }
        public void SetEmail(string email) { this.email = email; }

        // --------------- Behaviors ---------------
        // This class has no important behaviors
    }
}

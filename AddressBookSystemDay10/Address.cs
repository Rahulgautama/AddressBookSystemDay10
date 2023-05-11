using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystemDay10
{
    public class Address
    {
        public string firstName;
        public string lastName;
        public string address;
        public string state;
        public string city;
        public string zip;
        public int phoneNumber;
        public string email;

        public Address(string firstName, string lastName, string address, string state, string city, string zip, int phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.state = state;
            this.city = city;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;

        }
    }
}

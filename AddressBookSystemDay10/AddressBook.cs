using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystemDay10
{
    class AddressBook
    {
        List<Address> addresses;

        public AddressBook()
        {
            addresses = new List<Address>();
        }

        public bool add(string firstName, string lastName, string address, string state, string city, string zip, int phoneNumber, string email)
        {
            Address addr = new Address(firstName, lastName, address, city, state, zip, phoneNumber, email);
            Address result = find(firstName);

            if (result == null)
            {
                addresses.Add(addr);
                return true;
            }
            else
            {
                return false;
            }
        }
        public Address find(string firstName)
        {
            Address addr = addresses.Find((a) => a.firstName == firstName);
            return addr;
        }
        public bool remove(string firstName)
        {
            Address addr = find(firstName);

            if (addr != null)
            {
                addresses.Remove(addr);
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}

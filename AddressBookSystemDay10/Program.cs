using System;

namespace AddressBookSystemDay10
{
    class Program
    {
        class AddressPrompt
        {
            AddressBook book;

            public AddressPrompt()
            {
                book = new AddressBook();
            }

            static void Main(string[] args)
            {
                string selection = "";
                AddressPrompt prompt = new AddressPrompt();

                prompt.displayMenu();
                while (!selection.ToUpper().Equals("Q"))
                {
                    Console.WriteLine("Selection: ");
                    selection = Console.ReadLine();
                    prompt.performAction(selection);
                }
            }

            void displayMenu()
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine("=========");
                Console.WriteLine("A - Add an Address");
                Console.WriteLine("D - Delete an Address");
                Console.WriteLine("E - Edit an Address");
                //Console.WriteLine("L - List All Addresses");
                Console.WriteLine("Q - Quit");
            }

            void performAction(string selection)
            {
                string firstName = "";
                string lastName = "";
                string address = "";
                string city = "";
                string state = "";
                string zip = "";
                int phoneNumber = 0;
                string email = "";

                switch (selection.ToUpper())
                {
                    case "A":
                        Console.WriteLine("Enter FirstName: ");
                        firstName = Console.ReadLine();
                        Console.WriteLine("Enter LastName: ");
                        lastName = Console.ReadLine();
                        Console.WriteLine("Enter Address: ");
                        address = Console.ReadLine();
                        Console.WriteLine("Enter City: ");
                        city = Console.ReadLine();
                        Console.WriteLine("Enter State: ");
                        state = Console.ReadLine();
                        Console.WriteLine("Enter PhoneNumber: ");
                        phoneNumber = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Email: ");
                        email = Console.ReadLine();
                        if (book.add(firstName, lastName, address, city, state, zip, phoneNumber, email))
                        {
                            Console.WriteLine("successfully added!");
                        }
                        else
                        {
                            Console.WriteLine("An address is already on file for {0}.", firstName);
                        }
                        break;
                    case "E":
                        Console.WriteLine("Enter First Name to Edit: ");
                        firstName = Console.ReadLine();
                        Address addr = book.find(firstName);
                        if (addr == null)
                        {
                            Console.WriteLine("Address for {0} count not be found.", firstName);
                        }
                        else
                        {
                            Console.WriteLine("Enter new Address: ");
                            addr.address = Console.ReadLine();
                            Console.WriteLine("Address updated for {0}", firstName);
                        }
                        break;
                    case "D":
                        Console.WriteLine("Enter First Name to Delete: ");
                        firstName = Console.ReadLine();
                        if (book.remove(firstName))
                        {
                            Console.WriteLine("Details successfully removed");
                        }
                        else
                        {
                            Console.WriteLine("Address for {0} could not be found.", firstName);
                        }
                        break;

                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressBookMain
    {
        static void Main(string[] args)
        {
            Dictionary<string, AddressBook> addressBooks = new Dictionary<string, AddressBook>();

            while (true)
            {
                Console.WriteLine("Add a new address book:");
                Console.Write("Name: ");
                string name = Console.ReadLine();

                AddressBook newAddressBook = new AddressBook();
                addressBooks.Add(name, newAddressBook);

                Console.Write("Add another address book? (y/n): ");
                string answer = Console.ReadLine();
                if (answer.ToLower() != "y")
                {
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("Select an address book:");
                foreach (string name in addressBooks.Keys)
                {
                    Console.WriteLine(name);
                }
                Console.Write("Name: ");
                string selectedName = Console.ReadLine();

                if (addressBooks.ContainsKey(selectedName))
                {
                    AddressBook selectedAddressBook = addressBooks[selectedName];

                    while (true)
                    {
                        Console.WriteLine("Add a new person to the address book:");
                        Console.Write("First name: ");
                        string firstName = Console.ReadLine();
                        Console.Write("Last name: ");
                        string lastName = Console.ReadLine();
                        Console.Write("Address: ");
                        string address = Console.ReadLine();
                        Console.Write("City: ");
                        string city = Console.ReadLine();
                        Console.Write("State: ");
                        string state = Console.ReadLine();
                        Console.Write("Zip: ");
                        string zip = Console.ReadLine();
                        Console.Write("Phone number: ");
                        string phoneNumber = Console.ReadLine();
                        Console.Write("Email: ");
                        string email = Console.ReadLine();

                        Person newPerson = new Person(firstName, lastName, address, city, state, zip, phoneNumber, email);
                        selectedAddressBook.AddPerson(newPerson);

                        Console.Write("Add another person? (y/n): ");
                        string answer = Console.ReadLine();
                        if (answer.ToLower() != "y")
                        {
                            break;
                        }
                    }

                    Console.WriteLine($"All people in the {selectedName} address book:");
                    selectedAddressBook.DisplayPeople();
                }
                else
                {
                    Console.WriteLine("Invalid address book name.");
                }

                Console.Write("Select another address book? (y/n): ");
                string anotherAnswer = Console.ReadLine();
                if (anotherAnswer.ToLower() != "y")
                {
                    break;
                }
            }
        }
    }
}

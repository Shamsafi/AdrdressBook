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
            AddressBook addressBook = new AddressBook();

            Console.WriteLine("Add a new contact:");
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

            Contact newContact = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);
            addressBook.AddContact(newContact);

            Console.WriteLine("All contacts:");
            addressBook.DisplayContacts();

            Console.WriteLine("Delete an existing contact:");
            Console.Write("Enter first name of contact to delete: ");
            firstName = Console.ReadLine();
            Console.Write("Enter last name of contact to delete: ");
            lastName = Console.ReadLine();

            addressBook.DeleteContact(firstName, lastName);

            Console.WriteLine("All contacts:");
            addressBook.DisplayContacts();
        }
    }
}

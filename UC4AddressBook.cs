using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressBook
    {
        private List<Contact> contacts;

        public AddressBook()
        {
            contacts = new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

        public void DeleteContact(string firstName, string lastName)
        {
            Contact contact = FindContact(firstName, lastName);
            if (contact != null)
            {
                contacts.Remove(contact);
                Console.WriteLine("Contact deleted.");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }

        public void DisplayContacts()
        {
            foreach (Contact contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }

        private Contact FindContact(string firstName, string lastName)
        {
            foreach (Contact contact in contacts)
            {
                if (contact.FirstName == firstName && contact.LastName == lastName)
                {
                    return contact;
                }
            }
            return null;
        }
    }
}

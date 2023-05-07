using AddressBook;

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

        public void EditContact(string firstName, string lastName)
        {
            Contact contact = FindContact(firstName, lastName);
            if (contact != null)
            {
                Console.WriteLine("Enter new address:");
                contact.Address = Console.ReadLine();
                Console.WriteLine("Enter new city:");
                contact.City = Console.ReadLine();
                Console.WriteLine("Enter new state:");
                contact.State = Console.ReadLine();
                Console.WriteLine("Enter new zip:");
                contact.Zip = Console.ReadLine();
                Console.WriteLine("Enter new phone number:");
                contact.PhoneNumber = Console.ReadLine();
                Console.WriteLine("Enter new email:");
                contact.Email = Console.ReadLine();
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

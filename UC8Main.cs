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
            AddressBook addressBook1 = new AddressBook();
            addressBook1.AddPerson(new Person("Sam", "Smith", "WhiteField", "Banglore", "KA", "585417", "9857412630", "smith@gmail.com"));
            addressBook1.AddPerson(new Person("Will", "Smith", "Ameerpet", "Hyderabad", "TL", "545214", "8745213698", "will@gmail.com"));

            AddressBook addressBook2 = new AddressBook();
            addressBook2.AddPerson(new Person("Bob", "Curran", "Msk", "Kerala", "KL", "54321", "874512966", "bob@gmail.com"));
            addressBook2.AddPerson(new Person("Alice", "Jones", "MG-Road", "Bijapur", "KA", "09876", "845129637", "alice@gmail.com.com"));

            List<AddressBook> addressBooks = new List<AddressBook> { addressBook1, addressBook2 };

            Console.WriteLine("Search for a person by city or state:");
            Console.Write("City or state: ");
            string cityOrState = Console.ReadLine();

            List<Person> searchResults = new List<Person>();
            foreach (AddressBook addressBook in addressBooks)
            {
                searchResults.AddRange(addressBook.SearchByCity(cityOrState));
                searchResults.AddRange(addressBook.SearchByState(cityOrState));
            }

            if (searchResults.Count == 0)
            {
                Console.WriteLine("No results found.");
            }
            else
            {
                Console.WriteLine($"Found {searchResults.Count} result(s):");
                foreach (Person person in searchResults)
                {
                    Console.WriteLine(person);
                }
            }
        }
    }
}

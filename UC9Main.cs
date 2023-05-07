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
            addressBook.AddPerson(new Person("Sam", "Smith", "WhiteField", "Banglore", "KA", "585417", "9857412630", "smith@gmail.com"));
            addressBook.AddPerson(new Person("Will", "Smith", "Ameerpet", "Hyderabad", "TL", "545214", "8745213698", "will@gmail.com"));
            addressBook.AddPerson(new Person("Bob", "Curran", "Msk", "Kerala", "KL", "54321", "874512966", "bob@gmail.com"));
            addressBook.AddPerson(new Person("Alice", "Jones", "MG-Road", "Bijapur", "PY", "09876", "845129637", "alice@gmail.com.com"));

            Dictionary<string, List<Person>> peopleByCity = addressBook.GetPeopleByCity();
            Dictionary<string, List<Person>> peopleByState = addressBook.GetPeopleByState();

            Console.WriteLine("People by city:");
            foreach (KeyValuePair<string, List<Person>> entry in peopleByCity)
            {
                Console.WriteLine(entry.Key);
                foreach (Person person in entry.Value)
                {
                    Console.WriteLine($"- {person}");
                }
            }

            Console.WriteLine("People by state:");
            foreach (KeyValuePair<string, List<Person>> entry in peopleByState)
            {
                Console.WriteLine(entry.Key);
                foreach (Person person in entry.Value)
                {
                    Console.WriteLine($"- {person}");
                }
            }
        }
    }
}

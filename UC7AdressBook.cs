using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressBook
    {
        private List<Person> people;

        public AddressBook()
        {
            people = new List<Person>();
        }

        public void AddPerson(Person person)
        {
            if (!people.Contains(person))
            {
                people.Add(person);
            }
            else
            {
                Console.WriteLine("Duplicate person found.");
            }
        }

        public void DisplayPeople()
        {
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
        }

        public List<Person> SearchByName(string name)
        {
            return people.Where(person => person.FirstName.Contains(name) || person.LastName.Contains(name)).ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Person(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }

    class AddressBook
    {
        private List<Person> people;

        public AddressBook()
        {
            people = new List<Person>();
        }

        public void AddPerson(Person person)
        {
            people.Add(person);
        }

        public int GetCountByCity(string city)
        {
            return people.Count(person => person.City == city);
        }

        public int GetCountByState(string state)
        {
            return people.Count(person => person.State == state);
        }
    }

    class AddressBookMain
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();
            addressBook.AddPerson(new Person("Sam", "Smith", "WhiteField", "Bangalore", "KA", "585417", "9857412630", "smith@gmail.com"));
            addressBook.AddPerson(new Person("Will", "Smith", "Ameerpet", "Hyderabad", "TL", "545214", "8745213698", "will@gmail.com"));
            addressBook.AddPerson(new Person("Oliver", "Queen", "Banjara-Hills", "Hyderabad", "TL", "54896", "854123697", "queen@gmail.com"));
            addressBook.AddPerson(new Person("Bob", "Curran", "Msk", "Kerala", "KL", "54321", "874512966", "bob@gmail.com"));
            addressBook.AddPerson(new Person("Alice", "Jones", "MG-Road", "Bijapur", "PY", "09876", "845129637", "alice@gmail.com.com"));

            int countByCity = addressBook.GetCountByCity("Hyderabad");
            int countByState = addressBook.GetCountByState("PY");

            Console.WriteLine($"Number of people in Hyderabad (City): {countByCity}");
            Console.WriteLine($"Number of people in PY (State): {countByState}");
        }
    }
}
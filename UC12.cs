using System;
using System.Collections.Generic;

class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
}

class AddressBook
{
    private List<Person> people = new List<Person>();

    public void AddPerson(Person person)
    {
        people.Add(person);
    }

    public void SortByCity()
    {
        people.Sort((p1, p2) => p1.City.CompareTo(p2.City));
    }

    public void SortByState()
    {
        people.Sort((p1, p2) => p1.State.CompareTo(p2.State));
    }

    public void SortByZip()
    {
        people.Sort((p1, p2) => p1.Zip.CompareTo(p2.Zip));
    }

    public void DisplayPeople()
    {
        foreach (Person person in people)
        {
            Console.WriteLine(person.FirstName + " " + person.LastName);
            Console.WriteLine(person.Address);
            Console.WriteLine(person.City + ", " + person.State + " " + person.Zip);
            Console.WriteLine(person.Phone);
            Console.WriteLine(person.Email);
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        AddressBook addressBook = new AddressBook();

        Person person1 = new Person();
        person1.FirstName = "Will";
        person1.LastName = "Smith";
        person1.Address = "WhiteField";
        person1.City = "Bnagalore";
        person1.State = "KA";
        person1.Zip = "85414";
        person1.Phone = "8451257";
        person1.Email = "smith@gmail.com";

        Person person2 = new Person();
        person2.FirstName = "Sam";
        person2.LastName = "Smith";
        person2.Address = "MSK";
        person2.City = "Hyderabad";
        person2.State = "TL";
        person2.Zip = "84573";
        person2.Phone = "8845795126";
        person2.Email = "will@gmail.com";

        addressBook.AddPerson(person1);
        addressBook.AddPerson(person2);

        addressBook.SortByCity();
        addressBook.DisplayPeople();

        addressBook.SortByState();
        addressBook.DisplayPeople();

        addressBook.SortByZip();
        addressBook.DisplayPeople();
    }
}
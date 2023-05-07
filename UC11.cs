using System;
using System.Collections.Generic;

class Person : IComparable<Person>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    public int CompareTo(Person other)
    {
        return LastName.CompareTo(other.LastName);
    }

    public override string ToString()
    {
        return FirstName + " " + LastName + "\n" +
               Address + "\n" +
               City + ", " + State + " " + Zip + "\n" +
               Phone + "\n" +
               Email + "\n";
    }
}

class AddressBook
{
    private List<Person> people = new List<Person>();

    public void AddPerson(Person person)
    {
        people.Add(person);
    }

    public void SortPeople()
    {
        people.Sort();
    }

    public void DisplayPeople()
    {
        foreach (Person person in people)
        {
            Console.WriteLine(person);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        AddressBook addressBook = new AddressBook();

        Person person1 = new Person();
        person1.FirstName = "Aakash";
        person1.LastName = "Rao";
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

        addressBook.SortPeople();
        addressBook.DisplayPeople();
    }
}
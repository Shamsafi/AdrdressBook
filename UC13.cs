using System;
using System.Collections.Generic;
using System.IO;

class Person
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    public Person(string name, string address, string state, string zip, string phone, string email)
    {
        Name = name;
        Address = address;
        State = state;
        Zip = zip;
        Phone = phone;
        Email = email;
    }

    public override string ToString()
    {
        return $"{Name}, {Address}, {State}, {Zip}, {Phone}, {Email}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        var addressBook = new List<Person>()
        {
            new Person("Sam Smith", "Bnagalore", "KA", "58241", "8541236971", "smith@gmail.com"),
            new Person("John", "Hyderabad", "TL", "58831", "8541412971", "john@gmail.com"),
            new Person("Oliver Queen", "Delhi", "DL", "9652", "485963217", "queen@gmail.com"),
        };

        // Write the address book to a file
        using (var writer = new StreamWriter("address-book.txt"))
        {
            foreach (var person in addressBook)
            {
                writer.WriteLine($"{person.Name},{person.Address},{person.State},{person.Zip},{person.Phone},{person.Email}");
            }
        }

        // Clear the address book
        addressBook.Clear();

        // Read the address book from the file
        using (var reader = new StreamReader("address-book.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                addressBook.Add(new Person(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5]));
            }
        }

        // Print the address book to the console
        foreach (var person in addressBook)
        {
            Console.WriteLine(person);
        }
    }
}

using System;

namespace AddressBook
{
    class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contact(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
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

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}\nAddress: {Address}\nCity: {City}\nState: {State}\nZip: {Zip}\nPhone Number: {PhoneNumber}\nEmail: {Email}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Contact contact = new Contact("Sam", "Smith", "WhiteField", "Karnataka", "Bangalore", "12345", "9875632141", "samsmithe@example.com");
            Console.WriteLine(contact);
        }
    }
}
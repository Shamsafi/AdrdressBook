﻿using System;
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

            while (true)
            {
                Console.WriteLine("Add a new person to the address book:");
                Console.Write("First name: ");
                string firstName = Console.ReadLine();
                Console.Write("Last name: ");
                string lastName = Console.ReadLine();
                Console.Write("Address: ");
                string address = Console.ReadLine();
                Console.Write("City: ");
                string city = Console.ReadLine();
                Console.Write("State: ");
                string state = Console.ReadLine();
                Console.Write("Zip: ");
                string zip = Console.ReadLine();
                Console.Write("Phone number: ");
                string phoneNumber = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();

                Person newPerson = new Person(firstName, lastName, address, city, state, zip, phoneNumber, email);
                addressBook.AddPerson(newPerson);

                Console.Write("Add another person? (y/n): ");
                string answer = Console.ReadLine();
                if (answer.ToLower() != "y")
                {
                    break;
                }
            }

            Console.WriteLine("All people in the address book:");
            addressBook.DisplayPeople();
        }
    }
}

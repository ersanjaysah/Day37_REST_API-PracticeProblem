﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblems
{
    public class Person
    {
        /// <summary>
        /// Filds
        /// </summary>
        public string First_Name;
        public string Last_Name;
        public string Address;
        public string City;
        public string State;
        public int PostalCode;
        public long PhoneNumber;
        public string Email;

        public string Result()  // It will show the result.
        {
            return "\nName is: " + First_Name + " " + Last_Name + "\nAddress: " + Address + "\nCity is " + City +
                "\nState is " + State + "\nPostal code is: " + PostalCode + "\nPhone: " + PhoneNumber + "\nEmail is " + Email;
        }
    }
    public class AddressBookClass   // class
    {
        public List<Person> person = new List<Person>();

        public void Display()  // Will display the Details
        {
            Console.WriteLine("\nAddressBook is: ");
            foreach (Person per in person)
            {
                Console.WriteLine(per.Result());
            }
        }

        public void addPerson(Person p) //Adding person details
        {
            person.Add(p);
            string jsonData = JsonConvert.SerializeObject(person);
            File.WriteAllText(@"E:\BridgeLabzAssignment\Day37_PracticeProblems\AddressBookProblems\AddressBookProblems\personDetails.json", jsonData);
        }

        public AddressBookClass()   // constructor 
        {
            string json = File.ReadAllText(@"E:\BridgeLabzAssignment\Day37_PracticeProblems\AddressBookProblems\AddressBookProblems\personDetails.json");
            if (json.Length > 0)
            {
                person = JsonConvert.DeserializeObject<List<Person>>(json);
            }
            else
                person = new List<Person>();
        }
    }
}

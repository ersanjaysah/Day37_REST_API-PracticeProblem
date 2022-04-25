using System;

namespace AddressBookProblems
{
    public class Program //class
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the address book problem");
            AddressBookClass ad = new AddressBookClass();

            while (true) // it will give infinite loop.
            {
                Console.WriteLine("\nSelect Any one Operation: ");
                Console.WriteLine("1. To Add New Person: ");
                Console.WriteLine("2. To Display Contacts: ");
                Console.WriteLine("3. To Update details");
                Console.WriteLine("4. To Delete Details");
                int read = int.Parse(Console.ReadLine());
                switch (read)
                {
                    case 1:
                        Person person = new Person();
                        Console.WriteLine("Enter First Name: ");
                        string fname = Console.ReadLine();
                        person.First_Name = fname;

                        Console.WriteLine("Enter Last Name: ");
                        string lname = Console.ReadLine();
                        person.Last_Name = lname;

                        Console.WriteLine("Enter Address ");
                        string address = Console.ReadLine();
                        person.Address = address;

                        Console.WriteLine("Enter City: ");
                        string city = Console.ReadLine();
                        person.City = city;

                        Console.WriteLine("Enter State: ");
                        string state = Console.ReadLine();
                        person.State = state;

                        Console.WriteLine("Enter pin code: ");
                        int pin = int.Parse(Console.ReadLine());
                        person.PostalCode = pin;

                        Console.WriteLine("Enter Phone Number: ");
                        long number = long.Parse(Console.ReadLine());
                        person.PhoneNumber = number;

                        Console.WriteLine("Enter Email id: ");
                        string email = Console.ReadLine();
                        person.Email = email;

                        ad.addPerson(person);
                        break;

                    case 2:
                        ad.Display(); // here invoked Display method 
                        break;
                    case 3:
                        Console.WriteLine("Enter the name to Update");
                        string Name=Console.ReadLine();
                        ad.UpdateAddress(Name);
                        break;
                    case 4:
                        ad.Display();
                        Console.WriteLine("\n");
                        Console.WriteLine("Enter the first name which you want to detete");
                        string Name1 = Console.ReadLine();
                        ad.Remove(Name1);
                        break;
                }
            }
        }
    }
}

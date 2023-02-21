using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            AddressBookInfo myAddressBook = new AddressBookInfo();


            Console.WriteLine("Add new contact:");
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter country: ");
            string country = Console.ReadLine();
            Console.Write("Enter phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Enter email: ");
            string email = Console.ReadLine();

            Contact newCont = new Contact(firstName, lastName, country, phoneNumber, email);

            myAddressBook.AddContact(newCont);
            Console.WriteLine("Contact Details: ");
            myAddressBook.PrintContacts();


        }



    }
    
}

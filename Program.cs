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
            Contact newContact = new Contact("shiva", "barela", "INDIA", "9678534657", "shivabarela027@Gmail.com");
            myAddressBook.AddContact(newContact);
            myAddressBook.PrintContacts();

            myAddressBook.EditContacts("shiva", "barela","rajesh","bhadle", "INDIA", "9678534657", "vinubarela96@Gmail.com");
            myAddressBook.PrintContacts();


        }



    }
    
}

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
            Contact newContact1 = new Contact("shiva", "barela", "INDIA", "9678534657", "shivabarela027@Gmail.com");
            Contact newContact2 = new Contact("mayuri", "pawar", "US", "9654334657", "muyuriPawar453@Gmail.com");

            myAddressBook.AddContact(newContact1);
            myAddressBook.AddContact(newContact2);
            myAddressBook.PrintContacts();

            // myAddressBook.EditContacts("shiva", "barela","rajesh","bhadle", "INDIA", "9678534657", "vinubarela96@Gmail.com");
            myAddressBook.DeleteContact("shiva","barela");
            myAddressBook.PrintContacts();


        }



    }
    
}

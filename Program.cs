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
            myAddressBook.AddContact(newContact1);
            
            Contact newContact2 = new Contact("mayuri", "pawar", "US", "9654334657", "muyuriPawar453@Gmail.com");
            myAddressBook.AddContact(newContact2);

            Contact newContact3 = new Contact("vinesh"," barela", "INDIA", "9654334657", "vineshbhau32@Gmail.com");
            myAddressBook.AddContact(newContact3);
            myAddressBook.PrintContacts();

            
            


        }



    }
    
}

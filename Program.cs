using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class Program
    {
       public static void Main(string[] args)
        {
           AddressBookInfo myAddrBk = new AddressBookInfo();
            Contact newContact = new Contact("Barela", "Subhash", "INDIA", "7697335257", "barelasubhash16@gmail.com");

            myAddrBk.AddContact(newContact);
            myAddrBk.PrintContacts();
        }
        

        
    }
    
}

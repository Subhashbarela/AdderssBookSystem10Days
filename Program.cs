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
            Contact newContact = new Contact("Prince", "Praveen", "INDIA", "8369319177", "prince.p@example.com");

            myAddrBk.AddContact(newContact);
            myAddrBk.PrintContacts();
        }
        

        
    }
    
}

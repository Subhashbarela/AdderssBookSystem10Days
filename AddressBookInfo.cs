using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBookInfo
    {
        public Contact[] ContactInfo { get; set; }
        public int NumberOfContacts { get; set; }

        public AddressBookInfo()
        {
            ContactInfo = new Contact[100];
            NumberOfContacts = 0;
        }

        public void AddContact(Contact contact)
        {
            ContactInfo[NumberOfContacts] = contact;
            NumberOfContacts++;
        }


        public void PrintContacts()
        {
            for (int i = 0; i < NumberOfContacts; i++)
            {
                Console.WriteLine("Name: {0} {1}\nCountry: {2}\nPhone: {3}\nEmail: {4}\n",
                    ContactInfo[i].firstName, ContactInfo[i].lastName, ContactInfo[i].country, ContactInfo[i].phoneNumber, ContactInfo[i].email);
            }
        }
    }
}


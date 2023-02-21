using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class Contact
    {

         String fullname;
        String address;
       String state;
         String zip;
         String phone;

        public Contact(String fullname, String address,  String state, String zip, String phone)
        {
            this.fullname = fullname;
            this.address = address;
            
            this.state = state;
            this.zip = zip;
            this.phone = phone;


        }
        public  void dipslay()
        {
            Console.WriteLine("name is :" + fullname);
            Console.WriteLine("Address is :" + address);
            Console.WriteLine("state is :" + state);
            Console.WriteLine("zip code  is :" + zip);
            Console.WriteLine("phone number is :" + phone);

        }
    }
}

    


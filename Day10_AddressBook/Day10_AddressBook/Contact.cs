using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_AddressBook
{
    public class Contact
    {
        public string FirstName { get; set; } //The get method returns the value of the variable name//The set method assigns a value to the name variable
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhNo { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string[] Email { get; set; }

    }
}
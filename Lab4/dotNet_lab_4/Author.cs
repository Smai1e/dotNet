using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_lab_4
{
    class Author : Human
    {
        public Author()
        {

        }

        public Author(string firstName, string lastName, string middleName, string address, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Address = address;
            PhoneNumber = phoneNumber;
        }
    }
}

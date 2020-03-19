using System;
using System.Collections.Generic;
using System.Text;

namespace ListAndLoopsExample
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public string PhoneNumber;
        public string Email;

        public Person()
        {

        }

        public Person(string FirstName, string LastName, string PhoneNumber, string Email)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
        }
    }
}
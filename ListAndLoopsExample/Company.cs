using System;
using System.Collections.Generic;
using System.Text;

namespace ListAndLoopsExample
{
    class Company
    {
        public string CompanyName;
        public string ContactPerson;
        public string Country;

        public Company()
        {

        }
        public Company(string CompanyName, string ContactPerson, string Country)
        {
            this.CompanyName = CompanyName;
            this.ContactPerson = ContactPerson;
            this.Country = Country;
        }


    }
}

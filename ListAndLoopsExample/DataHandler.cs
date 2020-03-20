using System;
using System.Collections.Generic;
using System.Text;

namespace ListAndLoopsExample
{
    class DataHandler
    {
        public List<Coffee> coffees = new List<Coffee>();
        public List<Person> persons = new List<Person>();
        public List<Company> companys = new List<Company>();

        //Metodi jolla kysytään Kahvi
        public Coffee CreateCoffee()
        {

            //Merkki 
            Console.WriteLine("Enter Coffee Brand: ");
            var brand = Console.ReadLine();
            
            //Maahantuoja
            Console.WriteLine("\nEnter Coffee Importer: ");
            var importer = Console.ReadLine();

            //hinta
            Console.WriteLine("\nEnter Coffee Price (Example: 4,7 or 2,25): ");
            var price = Convert.ToDouble(Console.ReadLine());
            
            //paahto 1-5
            Console.WriteLine("\nEnter Coffee Roast: ");
            var roast = Convert.ToInt16(Console.ReadLine());


            Coffee toReturn = new Coffee(brand, importer, price);
            toReturn.roast = (Coffee.Roast)roast;
            return toReturn;
        }



        //Metodi jolla luodaan Henkilö
        public Person CreatePerson()
        {

            //Nimi
            Console.WriteLine("Enter Person Name: ");
            var FirstName = Console.ReadLine();

            //Sukunimi
            Console.WriteLine("\nEnter Last name: ");
            var LastName = Console.ReadLine();

            //Puh Numero
            Console.WriteLine("\nEnter Phonenumber: ");
            var PhoneNumber = Console.ReadLine();

            //Sähköposti
            Console.WriteLine("\nEnter Email: ");
            var Email = Console.ReadLine();


            Person toReturn = new Person(FirstName, LastName, PhoneNumber, Email);
            return toReturn;
        }


        //Metodi jolla luokaan Yritys
        public Company CreateCompany()
        {

            //nimi
            Console.WriteLine("Enter Company name: ");
            var CompanyName = Console.ReadLine();

            //yhteyshenkilö
            Console.WriteLine("\nEnter Contact persons name: ");
            var ContactPerson = Console.ReadLine();

            //maa
            Console.WriteLine("\nEnter Country: ");
            var Country = Console.ReadLine();


            Company toReturn = new Company(CompanyName, ContactPerson, Country);
            return toReturn;
        }
        
    }







}
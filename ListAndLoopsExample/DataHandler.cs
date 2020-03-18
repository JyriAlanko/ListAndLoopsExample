using System;
using System.Collections.Generic;
using System.Text;

namespace ListAndLoopsExample
{
    class DataHandler
    {
        public List<Coffee> coffees = new List<Coffee>();
        public List<Person> persons = new List<Person>();

        public Coffee CreateCoffee()
        {
            Console.WriteLine("Enter Coffee Brand: ");
            var brand = Console.ReadLine();

            //Maahantuoja
            Console.WriteLine("Enter Coffee Importer: ");
            var importer = Console.ReadLine();

            //hinta
            Console.WriteLine("Enter Coffee Price: ");
            var price = Console.ReadLine();


            //paahto 1-5
            Console.WriteLine("Enter Coffee Roast: ");
            var roast = Console.ReadLine();


            Coffee toReturn = new Coffee(brand);
            toReturn.roast = (Coffee.Roast)2;
            return toReturn;
        }

        public Person CreatePerson()
        {
            Console.WriteLine("Enter Person Name: ");
            var FirstName = Console.ReadLine();

            Console.WriteLine("Enter Last name: ");
            var LastName = Console.ReadLine();

            Console.WriteLine("Enter Phonenumber: ");
            var PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Email: ");
            var Email = Console.ReadLine();


            Person toReturn = new Person(FirstName, LastName, PhoneNumber, Email);
            return toReturn;
        }
        //metodi luo persoona
    }







}
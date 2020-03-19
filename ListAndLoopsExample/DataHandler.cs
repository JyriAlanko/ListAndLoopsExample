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
            //Merkki
            Console.WriteLine("Enter Coffee Brand: ");
            var brand = Console.ReadLine();

            //Maahantuoja
            Console.WriteLine("Enter Coffee Importer: ");
            var importer = Console.ReadLine();

            //hinta
            Console.WriteLine("Enter Coffee Price: ");
            var price = Convert.ToDouble(Console.ReadLine());
            

            //paahto 1-5
            Console.WriteLine("Enter Coffee Roast: ");
            var roast = Convert.ToInt16(Console.ReadLine());


            Coffee toReturn = new Coffee(brand, importer, price);
            toReturn.roast = (Coffee.Roast)roast;
            return toReturn;
        }

        //metodi luo persoona
        public Person CreatePerson()
        {
            //Nimi
            Console.WriteLine("Enter Person Name: ");
            var FirstName = Console.ReadLine();

            //Sukunimi
            Console.WriteLine("Enter Last name: ");
            var LastName = Console.ReadLine();

            //Puh Numero
            Console.WriteLine("Enter Phonenumber: ");
            var PhoneNumber = Console.ReadLine();

            //Sähköposti
            Console.WriteLine("Enter Email: ");
            var Email = Console.ReadLine();


            Person toReturn = new Person(FirstName, LastName, PhoneNumber, Email);
            return toReturn;
        }

       
        
    }







}
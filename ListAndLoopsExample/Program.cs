using System;
using System.Collections.Generic;
namespace ListAndLoopsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var dh = new DataHandler();
            var Coffee = dh.CreateCoffee();
            dh.coffees.Add(Coffee);
            var Person = dh.CreatePerson();
            dh.persons.Add(Person);

            //var paketti = new Coffee("Pressa", 4.0, Coffee.Roast.light, "Paulig");

            Console.WriteLine($"enum: {Coffee.roast}");
            Console.WriteLine($"Name:{Person.FirstName} {Person.LastName}");
            Console.WriteLine($"Their Phone number is: {Person.PhoneNumber} and Email: {Person.Email}");



            //var paketti1 = new Coffee("Presidentti");
            //var paketti2 = new Coffee("Kulta Katriina");
            //var paketti3 = new Coffee("Brazil");
            //var paketti4 = new Coffee("Löfberd");

            //List<Coffee> coffees = new List<Coffee>();
            //coffees.Add(paketti1);
            //coffees.Add(paketti2);
            //coffees.Add(paketti3);
            //coffees.Add(paketti4);



            //foreach (Coffee item in coffees)
            //{
            //    Console.WriteLine($"Merkki: {item.brand} ");

            //}

            //for (int i = 0; i < coffees.Count; i++)
            //{

            //    Console.WriteLine($"{i}.Merkki: {coffees[i].brand}");

            //}



            //Company -luokka: nimi, yhteyshenkilö(person), maa
            //Person -luokka: etunimi, sukunimi, puh numero, email
            //DataHandler -luokka: List<coffee>, List<person>
            //metodi joka kysyy kahvin merkin, hinnan, roast -> luo näistä instanssin Coffee -> lisää ko.instanssin listaan.
        }
    }

    //kahvi
    //merkki, paahto, hinta, maahantuoja
    //constructorit ilman parametrejä, pelkällä nimella, kaikilla atribuuteilla



}
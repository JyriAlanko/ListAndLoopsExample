using System;
using System.Collections.Generic;
namespace ListAndLoopsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var dh = new DataHandler();
            List<Coffee> coffees = new List<Coffee>();
            List<Person> persons = new List<Person>();
            List<Company> companys = new List<Company>();

        Start:
            Console.WriteLine(" 1.Add Coffee \n 2.Add Person \n 3.Add Company \n 4.Show Coffees \n 5.Show all persons \n 6.Show all companies \n 7.Exit");
            Console.WriteLine("Choose action(1-7):");
            var Menu = Convert.ToInt32(Console.ReadLine());




            switch (Menu)
            {
                //Lisätään Kahvi
                case 1:
                    
                    Console.WriteLine("Hei");
                    var Coffee = dh.CreateCoffee();
                    coffees.Add(Coffee);
                    goto Start;

                //Lisätään Henkilö
                case 2:
                    Console.WriteLine("Hey");
                    var Person = dh.CreatePerson();
                    persons.Add(Person);
                    goto Start;

                //Lisätään yritys
                case 3:
                    var Company = dh.CreateCompany();
                    companys.Add(Company);
                    goto Start;
                    

                //Näytettään kahvit
                case 4:
                    for (int i = 0; i < coffees.Count; i++)
                    {

                        Console.WriteLine($"\n\nMerkki: {coffees[i].brand} \nMaahantuoja: {coffees[i].importer} \nHinta: {coffees[i].price}e \nPaahto: {coffees[i].roast} ");

                    }
                    break;

                //Näytetään henkilöt
                case 5:
                    for (int i = 0; i < persons.Count; i++)
                    {

                        Console.WriteLine($"\n\nEtunimi: {persons[i].FirstName} \nSukunimi: {persons[i].LastName} \nPuhelinNum: {persons[i].PhoneNumber} \nEmail: {persons[i].Email} ");

                    }

                    break;

                //Näytetään yritykset
                case 6:
                    for (int i = 0; i < companys.Count; i++)
                    {

                        Console.WriteLine($"\n\nnimi: {companys[i].CompanyName} \nYhteyshenkilö: {companys[i].ContactPerson} \nMaa: {companys[i].Country} ");

                    }

                    break;

                //Exit
                case 7:
                    break;
            }







            //var paketti = new Coffee("Pressa", 4.0, Coffee.Roast.light, "Paulig");

            //Console.WriteLine($"\nenum: {Coffee.roast}");
            //Console.WriteLine($"\nName: {Person.FirstName} {Person.LastName}");
            //Console.WriteLine($"\nPhone number: {Person.PhoneNumber}\nEmail: {Person.Email}");
            //Console.WriteLine($"\nCompany name: {Company.CompanyName}\nContact person: {Company.ContactPerson}\nCountry: {Company.Country}");






            //var paketti1 = new Coffee("Presidentti");
            //var paketti2 = new Coffee("Kulta Katriina");
            //var paketti3 = new Coffee("Brazil");
            //var paketti4 = new Coffee("Löfberd");
            //coffees.Add(paketti1);
            //coffees.Add(paketti2);
            //coffees.Add(paketti3);
            //coffees.Add(paketti4);



            //foreach (Coffee item in coffees)
            //{
            //    Console.WriteLine($"Merkki: {item.brand} ");
            //    Console.WriteLine($"Maahantuoja: {item.importer}");
            //    Console.WriteLine($"Hinta: {item.price}");
            //    Console.WriteLine($"Paahto: {item.roast}");

            //}

            //for (int i = 0; i < coffees.Count; i++)
            //{

            //    Console.WriteLine($"{i}.Merkki: {coffees[i].brand}");

        }



        //Company -luokka: nimi, yhteyshenkilö(person), maa
        //Person -luokka: etunimi, sukunimi, puh numero, email
        //DataHandler -luokka: List<coffee>, List<person>
        //metodi joka kysyy kahvin merkin, hinnan, roast -> luo näistä instanssin Coffee -> lisää ko.instanssin listaan.
    }
 }

    //kahvi
    //merkki, paahto, hinta, maahantuoja
    //constructorit ilman parametrejä, pelkällä nimella, kaikilla atribuuteilla




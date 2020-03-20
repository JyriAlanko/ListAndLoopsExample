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

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            string textToEnter = "Welcome! Please choose action";
            Console.WriteLine(string.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));

            Console.WriteLine("\n\n\n 1.Add Coffee \n 2.Add Person \n 3.Add Company \n 4.Show Coffees \n 5.Show all persons \n 6.Show all companies \n 7.Exit");
            Console.WriteLine("\n\nChoose action(1-7):");
            var Menu = Convert.ToInt32(Console.ReadLine());
            



            switch (Menu)
            {
                //Lisätään Kahvi
                case 1:
                    
                    Console.Clear();
                    Console.WriteLine("Let's add coffee information! \n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    var Coffee = dh.CreateCoffee();
                    coffees.Add(Coffee);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.WriteLine("Do you wanna add another coffee? (Y/N) \n");
                    string KahviValinta = Console.ReadLine();

                    if (KahviValinta == "Y" || KahviValinta == "y")
                    {

                        goto case 1;
                    }

                    else
                    {
                        goto Start;
                    }
                    
                    



                //Lisätään Henkilö
                case 2:
                    Console.Clear();
                    Console.WriteLine("Let's add person information! \n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    var Person = dh.CreatePerson();
                    persons.Add(Person);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.WriteLine("Do you wanna add another person? (Y/N) \n");
                    string HenkilöValinta = Console.ReadLine();

                    if (HenkilöValinta == "Y")
                    {
                        goto case 1;
                    }

                    else
                    {

                    goto Start;
                    }



                //Lisätään yritys
                case 3:

                    Console.Clear();
                    Console.WriteLine("Let's add company information! \n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    var Company = dh.CreateCompany();
                    companys.Add(Company);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.WriteLine("Do you wanna add another company? (Y/N) \n");
                    string YritysValinta = Console.ReadLine();

                    if(YritysValinta == "Y")
                    {
                        goto case 1;
                    }

                    else
                    {

                    goto Start;
                    }
                    


                //Näytettään kahvit
                case 4:
                    Console.Clear();
                    int Merkki = 1;
                    for (int i = 0; i < coffees.Count; i++)
                    {
                        
                        Console.WriteLine($"{Merkki}.\nMerkki: {coffees[i].brand} \nMaahantuoja: {coffees[i].importer} \nHinta: {coffees[i].price}e \nPaahto: {coffees[i].roast} \n\n");
                        Merkki++;

                    }
                    Console.ReadKey();
                goto Start;



                //Näytetään henkilöt
                case 5:
                    int Nimi = 1;
                    for (int i = 0; i < persons.Count; i++)
                    {

                        Console.WriteLine($"{Nimi}.\nEtunimi: {persons[i].FirstName} \nSukunimi: {persons[i].LastName} \nPuhelinNum: {persons[i].PhoneNumber} \nEmail: {persons[i].Email} \n\n");
                        Nimi++;
                    }
                    Console.ReadKey();
                    goto Start;



                //Näytetään yritykset
                case 6:
                    int Yritys = 1;
                    Console.Clear();
                    for (int i = 0; i < companys.Count; i++)
                    {

                        Console.WriteLine($"{Yritys}.\nNimi: {companys[i].CompanyName} \nYhteyshenkilö: {companys[i].ContactPerson} \nMaa: {companys[i].Country} \n\n");
                        Yritys++;
                    }
                    Console.ReadKey();
                    goto Start;


                //Exit
                case 7:
                    break;
            }







        }
    }
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


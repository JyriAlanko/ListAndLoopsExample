using System;
using System.Collections.Generic;
using System.Text;

namespace ListAndLoopsExample
{
    class Coffee
    {
        public enum Roast { light = 1, lightmedium, medium, darkmedium, dark }

        public string brand;
        public double price;
        public Roast roast;
        public string importer;


        public Coffee()
        {

        }

        public Coffee(string brand)
        {
            this.brand = brand;
        }

        public Coffee(string brand, double price)
        {
            this.brand = brand;
            this.price = price;
        }

        public Coffee(string brand, string importer, double price)
        {
            this.brand = brand;
            this.importer = importer;
            this.price = price;
        }

        public Coffee(string brand, string importer, double price, Roast roast)
        {
            this.brand = brand;
            this.importer = importer;
            this.price = price;
            this.roast = roast;
        }
    }
}
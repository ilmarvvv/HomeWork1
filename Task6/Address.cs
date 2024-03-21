using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    internal class Address
    {
        private string name;
        private string index, country, city, street, house, apartment;


        public string Name { 
            get { return name; }
            set { name = value; }
        }
        public string Index {
            get { return index; }
            set { index = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public string House
        {
            get { return house; }
            set { house = value; }
        }
        public string Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }

        public void Show()
        {
            Console.WriteLine("Address:");
            Console.WriteLine($"\t{name}");
            Console.WriteLine($"\t{apartment}-{house} {street}");
            Console.WriteLine($"\t{city} {index}");
            Console.WriteLine($"\t{country}");
        }
    }
}

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Management
{
    internal class Animal
    {
        private string v1;
        private string v2;
        private int v3;
        private string v4;

        public string Classification { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public string Location { get; set; }

        public Animal(string classification, string name, int age, int weight, string location)
        {
            Classification = classification;
            Name = name;
            Age = age;
            Weight = weight;
            Location = location;
        }

        public Animal(string v1, string v2, int v3, string v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }

        public void MoveTo(string newLocation)
        {
            Console.WriteLine($"{Name} is moving from {Location} to {newLocation}");
            Location = newLocation;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Classification: {Classification}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Location: {Location}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal lion = new Animal("Simba", "Lion", 5, "Africa");

            lion.DisplayInfo();

            lion.MoveTo("Pretoria Zoo");

            lion.DisplayInfo();
        }
    }
}
*/
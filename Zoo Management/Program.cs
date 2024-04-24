using System;
using System.Collections.Generic;
using Zoo_Management;
using ZooManagementApp.Menu;

namespace ZooManagementApp
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to JOY ZOO Management APP <3");
            Console.WriteLine("THE GREATNESS OF A NATION CAN BE JUDGED BY THE WAY ITS ANIMALS ARE TREATED");
            Console.WriteLine();

            // Display options
            Menus.Display();

            // Read user input
            int option = int.Parse(Console.ReadLine());

            // Perform based on selected option
            Menus.ProcessOption(option);
        }
    }

    namespace Menu
    {
        public class Menus
        {
            public static void Display()
            {
                Console.WriteLine("Please choose an option:");
                Console.WriteLine();
                Console.WriteLine("1. Animals that can be seen in JOY Zoo");
                Console.WriteLine("2. Add Animal");
                Console.WriteLine("3. Track");
                Console.WriteLine("4. Interaction");
                Console.WriteLine("5. Exit");
            }

            public static void ProcessOption(int option)
            {
                switch (option)
                {
                    case 1:
                        Console.WriteLine("You selected option 1");
                        availableAnimals();
                        break;
                    case 2:
                        Console.WriteLine("You selected Option 2.");
                        getAnimalInformation();
                        break;
                    case 3:
                        Console.WriteLine("You selected Option 3.");
                        AnimalTracking();
                        break;
                    case 4:
                        Console.WriteLine("You selected Option 4.");
                        AnimalInteraction();
                        break;
                    case 5:
                        Console.WriteLine("Exiting...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please select a valid option.");
                        break;
                }
            }

            // Method to display available animals
            static void availableAnimals()
            {
                Console.WriteLine("These are the animals you'll find in JOY ZOO");
                // Array of Available Animals
                string[] animals = {
                    "Elephant",
                    "Shark",
                    "Buffalo",
                    "Godzilla"
                };

                Console.WriteLine();
                foreach (string animal in animals)
                {
                    Console.WriteLine(animal);
                }
            }

            // Method to get information about a new animal
            static void getAnimalInformation()
            {
                Console.WriteLine("What is the animal's classification:");
                string classification = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Name of animal : ");
                string name = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Age  : ");
                string age = Console.ReadLine();
                Console.WriteLine();

                // Validate weight input
                double weight;
                bool validWeight = false;
                do
                {
                    Console.WriteLine("Weight of the animal :");
                    string weightInput = Console.ReadLine();
                    Console.WriteLine();

                    // Try parsing the input into a double
                    if (double.TryParse(weightInput, out weight))
                    {
                        // Checking if the weight is within acceptable range 
                        if (weight >= 0 && weight <= 10000)
                        {
                            validWeight = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid weight. Weight must be between 0 and 10000.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid numeric weight.");
                    }
                } while (!validWeight);

                Console.WriteLine("Habitat (Place where animal makes home)  :");
                string habitat = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Animal added successfully, " + name + " is part of the JOY ZOO");
                Console.WriteLine("THANK YOU <3.");
            }

            // Method to track animals
            private static void AnimalTracking()
            {
                Console.WriteLine("Location of all animals in JOY ZOO");
                // Create a list to hold animals
                List<AnimalTracking> animals = new List<AnimalTracking>();

                // Add animals to the list
                animals.Add(new Elephant("Filly", 24, 4000, "Zoo Forest"));
                animals.Add(new Shark("Killer", 17, 105, "Aquaria"));
                animals.Add(new Buffalo("Cyril", 67, 78, "Besides Entrance 1"));
                animals.Add(new Godzilla("Goerge", 1532, 8000, "Zoo Forest"));

                // Display information of all animals
                Console.WriteLine();
                foreach (var animal in animals)
                {
                    animal.DisplayInfo();
                    Console.WriteLine();
                }
            }

            // Method for animal interaction
            private static void AnimalInteraction()
            {
                Console.WriteLine("Interacting with animals in JOY ZOO");

                // Create instances of animals and interact with them
                Elephant elephant = new Elephant("Filly", 24, 4000, "Zoo Forest");
                Shark shark = new Shark("Killer", 17, 105, "Aquaria");
                Buffalo buffalo = new Buffalo("Cyril", 67, 78, "Besides Entrance 1");
                Godzilla godzilla = new Godzilla("Goerge", 1532, 8000, "Zoo Forest");

                // Interact with each animal
                Console.WriteLine();
                Console.WriteLine("Interacting with elephant:");
                elephant.DisplayInfo();
                elephant.Feed();
                elephant.Move();
                elephant.MakeSound();

                Console.WriteLine();
                Console.WriteLine("Interacting with shark:");
                shark.DisplayInfo();
                shark.Feed();
                shark.Move();
                shark.MakeSound();

                Console.WriteLine();
                Console.WriteLine("Interacting with buffalo:");
                buffalo.DisplayInfo();
                buffalo.Feed();
                buffalo.Move();
                buffalo.MakeSound();

                Console.WriteLine();
                Console.WriteLine("Interacting with godzilla:");
                godzilla.DisplayInfo();
                godzilla.Feed();
                godzilla.Move();
                godzilla.MakeSound();
            }

        }
    }
}
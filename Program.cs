﻿using System;
using System.Collections.Generic;
using System.Text.Json;

namespace StoreApp
{
    class Program
    {
        private static ProductLogic productLogic = new ProductLogic();

        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to add a product");
            Console.WriteLine("Press 2 to view a dog leash by name");
            Console.WriteLine("Type 'exit' to quit");
            string userInput = Console.ReadLine();

            while (userInput.ToLower() != "exit")
            {
                Console.WriteLine("Press 1 to add a product");
                Console.WriteLine("Press 2 to view a dog leash by name");
                Console.WriteLine("Type 'exit' to quit");

                if (userInput == "1")
                {
                    Console.WriteLine("Enter the type of product (catfood or dogleash): ");
                    string productType = Console.ReadLine().ToLower();

                    if (productType == "catfood")
                    {
                        CatFood catFood = new CatFood();

                        Console.WriteLine("Enter Name: ");
                        catFood.Name = Console.ReadLine();

                        Console.WriteLine("Enter Price: ");
                        catFood.Price = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Quantity: ");
                        catFood.Quantity = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Description: ");
                        catFood.Description = Console.ReadLine();

                        Console.WriteLine("Enter Weight (pounds): ");
                        catFood.WeightPounds = double.Parse(Console.ReadLine());

                        Console.WriteLine("Is it Kitten Food? (true/false): ");
                        catFood.KittenFood = bool.Parse(Console.ReadLine());

                        productLogic.AddProduct(catFood);
                        Console.WriteLine("Cat food added successfully.");
                    }
                    else if (productType == "dogleash")
                    {
                        DogLeash dogLeash = new DogLeash();

                        Console.WriteLine("Enter Name: ");
                        dogLeash.Name = Console.ReadLine();

                        Console.WriteLine("Enter Price: ");
                        dogLeash.Price = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Quantity: ");
                        dogLeash.Quantity = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Description: ");
                        dogLeash.Description = Console.ReadLine();

                        Console.WriteLine("Enter Length (inches): ");
                        dogLeash.LengthInches = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Material: ");
                        dogLeash.Material = Console.ReadLine();

                        productLogic.AddProduct(dogLeash);
                        Console.WriteLine("Dog leash added successfully.");
                    }
                }
                else if (userInput == "2")
                {
                    Console.WriteLine("Enter the name of the dog leash: ");
                    string name = Console.ReadLine();

                    try
                    {
                        DogLeash dogLeash = productLogic.GetDogLeashByName(name);
                        Console.WriteLine(JsonSerializer.Serialize(dogLeash));
                    }
                    catch (KeyNotFoundException)
                    {
                        Console.WriteLine("Dog leash not found.");
                    }
                }

                userInput = Console.ReadLine();
            }
        }
    }
}

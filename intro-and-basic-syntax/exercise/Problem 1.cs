//CONFIRMED from NikolayKIvanov
using System;
using System.Collections.Generic;

namespace _05._Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            //reading ingrediants from the console.
            string[] input = Console.ReadLine().Split();
            int number = int.Parse(Console.ReadLine());
            List<string> ingadients = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                if (ingadients.Count >= 10)
                {
                    break;
                }
                if (input[i].Length == number)
                {
                    ingadients.Add(input[i]);
                }
            }
            //adding ingrediants to pizza
            for (int i = 0; i < ingadients.Count; i++)
            {
                Console.WriteLine($"Adding {ingadients[i]}.");
            }
            //print pizza
            Console.WriteLine($"Made pizza with total of {ingadients.Count} ingredients.");
            //print ingrediants
            Console.WriteLine($"The ingredients are: {string.Join(", ", ingadients)}.");

        }
    }
}

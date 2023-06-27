using System;
using System.Collections.Generic;

namespace T03._P_rates
{
    internal class Program
    {
        class City
        {
            public City(int people, int gold)
            {
                this.People = people;
                this.Gold = gold;
            }

            public int People { get; set; }
            public int Gold { get; set; }
        }

        static void Main(string[] args)
        {
            Dictionary<string, City> cities = new Dictionary<string, City>();

            string input = Console.ReadLine();

            while (input != "Sail")
            {
                string[] array = input.Split("||");

                if (cities.ContainsKey(array[0]))
                {
                    cities[array[0]].People += int.Parse(array[1]);
                    cities[array[0]].Gold += int.Parse(array[2]);
                }
                else
                {
                    cities.Add(array[0], new City(int.Parse(array[1]), int.Parse(array[2])));
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                string[] array = input.Split("=>");

                string town = array[1];

                if (array[0] == "Plunder")
                {
                    int people = int.Parse(array[2]);
                    int gold = int.Parse(array[3]);

                    cities[town].People -= people;
                    cities[town].Gold -= gold;
                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (cities[town].People == 0 || cities[town].Gold == 0)
                    {
                        cities.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                }

                else
                {
                    int gold = int.Parse(array[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                    }

                    else
                    {
                        cities[town].Gold += gold;

                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cities[town].Gold} gold.");
                    }
                }

                input = Console.ReadLine();
            }

            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

                foreach (var city in cities)
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value.People} citizens, Gold: {city.Value.Gold} kg");
                }
            }

            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
using System;
using System.Collections.Generic;

namespace T03._Plant_Discovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Plant> plants = new Dictionary<string, Plant>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] plantInput = Console.ReadLine().Split("<->");

                if (!plants.ContainsKey(plantInput[0]))
                {
                    plants.Add(plantInput[0], new Plant(int.Parse(plantInput[1]), 0, 0));
                }
                else
                {
                    plants[plantInput[0]].Rarity = int.Parse(plantInput[1]);
                }
            }

            string input = Console.ReadLine();

            while (input != "Exhibition")
            {
                string[] command = input.Split(" ");
                string plant = command[1];

                if (command[0] == "Rate:")
                {
                    if (plants.ContainsKey(plant))
                    {
                        plants[plant].Rate += double.Parse(command[3]);
                        plants[plant].Average++;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }

                else if (command[0] == "Update:")
                {
                    if (plants.ContainsKey(plant))
                    {
                        plants[plant].Rarity = int.Parse(command[3]);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }

                else if (command[0] == "Reset:")
                {
                    if (plants.ContainsKey(plant))
                    {
                        plants[plant].Rate = 0;
                        plants[plant].Average = 0;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Plants for the exhibition:");

            foreach (var item in plants)
            {
                if (item.Value.Average == 0)
                {
                    Console.WriteLine($"- {item.Key}; Rarity: {item.Value.Rarity}; Rating: {item.Value.Rate:f2}");
                }
                else
                {
                    double average = item.Value.Rate / item.Value.Average;
                    Console.WriteLine($"- {item.Key}; Rarity: {item.Value.Rarity}; Rating: {average:f2}");
                }
            }
        }
        class Plant
        {
            public Plant(int rarity, double rate, int average)
            {
                this.Rarity = rarity;
                this.Rate = rate;
                this.Average = average;
            }

            public int Rarity { get; set; }
            public double Rate { get; set; }
            public int Average { get; set; }
        }
    }
}

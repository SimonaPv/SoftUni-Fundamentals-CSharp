using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02.Space_Travel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine()
               .Split(new string[] { "||" }, StringSplitOptions.None)
               .ToArray();

            int fuel = int.Parse(Console.ReadLine());
            int ammunition = int.Parse(Console.ReadLine());

            for (int j = 0; j <= commands.Length - 1; j++)
            {
                string[] array = commands[j].Split(' ');
                string action = array[0];

                if (action != "Titan")
                {
                    int num = int.Parse(array[1]);
                }

                if (action == "Travel")
                {
                    int num = int.Parse(array[1]);
                    int distance = 0;
                    for (int s = 0; s < num; s++)
                    {
                        fuel--;
                        distance++;
                    }
                    if (fuel < 0)
                    {
                        Console.WriteLine("Mission failed.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"The spaceship travelled {distance} light-years.");
                    }
                }

                else if (action == "Enemy")
                {
                    int num = int.Parse(array[1]);

                    if (ammunition >= num)
                    {
                        Console.WriteLine($"An enemy with {num} armour is defeated.");
                        ammunition -= num;
                    }

                    else if (ammunition < num)
                    {
                        
                        for (int i = 0; i < num; i++)
                        {
                            fuel -= 2;
                        }
                        if (fuel < 0)
                        {
                            Console.WriteLine("Mission failed.");
                            return;
                        }
                        Console.WriteLine($"An enemy with {num} armour is outmaneuvered.");
                    }

                }

                else if (action == "Repair")
                {
                    int num = int.Parse(array[1]);
                    int numberF = num;
                    int numberA = num * 2;
                    fuel += numberF;
                    ammunition += numberA;
                    Console.WriteLine($"Ammunitions added: {numberA}.");
                    Console.WriteLine($"Fuel added: {numberF}.");
                }

                else if (action == "Titan")
                {
                    Console.WriteLine($"You have reached Titan, all passengers are safe.");
                }
            }
        }
    }
}


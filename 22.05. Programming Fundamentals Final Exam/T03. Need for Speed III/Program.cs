using System;
using System.Collections.Generic;

namespace T03._Need_for_Speed_III
{
    class Car
    {
        public Car(int mileage, int fuel)
        {
            this.Mileage = mileage;
            this.Fuel = fuel;
        }

        public int Mileage { get; set; }
        public int Fuel { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] array = Console.ReadLine()
                    .Split("|");
                cars.Add(array[0], new Car(int.Parse(array[1]), int.Parse(array[2])));
            }

            string input = Console.ReadLine();

            while (input != "Stop")
            {
                string[] action = input.Split(" : ");
                string car = action[1];

                if (action[0] == "Drive")
                {
                    if (cars[car].Fuel >= int.Parse(action[3]))
                    {
                        cars[car].Mileage += int.Parse(action[2]);
                        cars[car].Fuel -= int.Parse(action[3]);

                        Console.WriteLine($"{car} driven for {int.Parse(action[2])} kilometers. {int.Parse(action[3])} liters of fuel consumed.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough fuel to make that ride");
                    }

                    if (cars[car].Mileage >= 100000)
                    {
                        Console.WriteLine($"Time to sell the {car}!");
                    }
                }

                else if (action[0] == "Refuel")
                {
                    int fuel = cars[car].Fuel + int.Parse(action[2]);

                    if (fuel > 75)
                    {
                        int liters = 75 - cars[car].Fuel;
                        cars[car].Fuel = 75;
                        Console.WriteLine($"{car} refueled with {liters} liters");
                    }
                    else
                    {
                        cars[car].Fuel += int.Parse(action[2]);
                        Console.WriteLine($"{car} refueled with {int.Parse(action[2])} liters");
                    }
                }

                else if (action[0] == "Revert")
                {
                    cars[car].Mileage -= int.Parse(action[2]);

                    if (cars[car].Mileage < 10000)
                    {
                        cars[car].Mileage = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{car} mileage decreased by {int.Parse(action[2])} kilometers");
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Key} -> Mileage: {item.Value.Mileage} kms, Fuel in the tank: {item.Value.Fuel} lt.");
            }
        }
    }
}

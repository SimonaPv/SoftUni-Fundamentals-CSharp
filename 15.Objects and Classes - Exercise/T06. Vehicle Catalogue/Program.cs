using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            double carPower = 0;
            double truckPower = 0;
            int cars = 0;
            int trucks = 0;

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input.Split();
                Vehicle vehicle = new Vehicle(tokens[0], tokens[1], tokens[2], int.Parse(tokens[3]));

                if (vehicle.Type == "car")
                {
                    vehicles.Add(vehicle);
                    carPower += vehicle.HorsePower;
                    cars++;
                }

                else if (vehicle.Type == "truck")
                {
                    vehicles.Add(vehicle);
                    truckPower += vehicle.HorsePower;
                    trucks++;
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Close the Catalogue")
            {
                Vehicle searchedCar = vehicles.FirstOrDefault(x => x.Model == input);
               
                Console.WriteLine(searchedCar.ToString());

                input = Console.ReadLine();
            }

            double averageCarPower = carPower / cars;
            double averageTruckPower = truckPower / trucks;

            if (averageCarPower > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averageCarPower:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }

            if (averageTruckPower > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {averageTruckPower:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }
        }
    }

    class Vehicle
    { 
        public Vehicle(string type, string model, string color, int horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }
    
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public override string ToString()
        {
            if (Type == "car")
            {
                Type = "Car";
            }
            else if(Type == "truck")
            {
                Type = "Truck";
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Type: {Type}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Horsepower: {HorsePower}");
            return sb.ToString().TrimEnd();
        }
    }
}

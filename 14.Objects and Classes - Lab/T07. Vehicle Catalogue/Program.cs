using System;
using System.Collections.Generic;
using System.Linq;

namespace T07._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalogue catalogue = new Catalogue();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split("/");

                if (tokens[0] == "Truck")
                {
                    Truck truck = new Truck(tokens[1], tokens[2], int.Parse(tokens[3]));
                    catalogue.Trucks.Add(truck);
                }

                else if (tokens[0] == "Car")
                {
                    Car car = new Car(tokens[1], tokens[2], int.Parse(tokens[3]));
                    catalogue.Cars.Add(car);
                }

                input = Console.ReadLine();
            }

            if (catalogue.Cars.Count > 0)
            {
                List<Car> orderedCars = catalogue.Cars
                    .OrderBy(c => c.Brand)
                    .ToList();

                Console.WriteLine("Cars:");

                foreach (var car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (catalogue.Trucks.Count > 0)
            {
                List<Truck> orderedTrucks = catalogue.Trucks
                    .OrderBy(c => c.Brand)
                    .ToList();

                Console.WriteLine("Trucks:");

                foreach (var truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }

    class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    class Catalogue
    {
        public Catalogue()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace T06._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split();

                Box box = new Box(tokens[0], new Item(tokens[1], decimal.Parse(tokens[3])), int.Parse(tokens[2]));

                boxes.Add(box); 

                input = Console.ReadLine(); 
            }

            List<Box> orderdBoxes = boxes
                .OrderByDescending(box => box.Price)
                .ToList();

            foreach (Box box in orderdBoxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.Price:f2}");
            }
        }
    }

    class Item
    {
        public Item(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Box
    {
        public Box(string serialNumber, Item item, int itemQuantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = itemQuantity;
        }
    
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal Price
        {
            get
            {
                return this.ItemQuantity * this.Item.Price;
            }
        }
    }
}

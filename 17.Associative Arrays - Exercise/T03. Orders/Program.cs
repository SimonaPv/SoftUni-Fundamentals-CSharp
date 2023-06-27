using System;
using System.Collections.Generic;

namespace T03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> nameAndPrice = new Dictionary<string, double>();
            Dictionary<string, int> nameAndQuantity = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] product = input.Split();

                string name = product[0];
                double price = double.Parse(product[1]);
                int quantity = int.Parse(product[2]);   

                if (!nameAndPrice.ContainsKey(name))
                {
                    nameAndPrice.Add(name, price);
                    nameAndQuantity.Add(name, quantity);
                }
                else if(nameAndPrice.ContainsKey(name))
                {
                    nameAndPrice.Remove(name);
                    nameAndPrice.Add(name, price);
                    nameAndQuantity[name] += quantity;
                }

                input = Console.ReadLine();
            }

            foreach (var itemPrice in nameAndPrice)
            {
                foreach (var itemQuantity in nameAndQuantity)
                {
                    if (itemPrice.Key == itemQuantity.Key)
                    {
                        Console.WriteLine($"{itemQuantity.Key} -> {itemQuantity.Value * itemPrice.Value:f2}");
                    }
                }
            }
        }
    }
}

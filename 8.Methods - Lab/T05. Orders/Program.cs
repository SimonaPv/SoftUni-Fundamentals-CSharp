using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05.Orders
{
    internal class Program
    {
        static void Shopping(string product, int quantity)
        {
            double price = 0;
            if (product == "coffee")
            {
                price = quantity * 1.5;
            }
            else if (product == "water")
            {
                price = quantity * 1;
            }
            else if (product == "coke")
            {
                price = quantity * 1.4;
            }
            else if (product == "snacks")
            {
                price = quantity * 2;
            }

            Console.WriteLine($"{price:f2}");   
        }
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            Shopping(product, quantity);    
        }
    }
}

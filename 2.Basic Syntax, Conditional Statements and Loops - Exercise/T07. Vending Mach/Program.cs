using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T07.Vending_Mach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double totalMoney = 0;

            while (command != "Start")
            {
                double inputMoney = double.Parse(command);

                if (inputMoney == 0.1 || inputMoney == 0.2 || inputMoney == 0.5 || inputMoney == 1 || inputMoney == 2)
                {
                    totalMoney += inputMoney;
                }
                else { Console.WriteLine($"Cannot accept {inputMoney}"); }

                command = Console.ReadLine(); 
            }

            command = Console.ReadLine();   
            double totalPrice = 0;

            while (command != "End")
                {
                    if (command == "Nuts")
                    {
                        totalPrice = 2;
                    }
                    else if (command == "Water")
                    {
                        totalPrice = 0.7;
                    }
                    else if (command == "Crisps")
                    {
                        totalPrice = 1.5;
                    }
                    else if (command == "Soda")
                    {
                        totalPrice = 0.8;
                    }
                    else if (command == "Coke")
                    {
                        totalPrice = 1.0;
                    }
                    else 
                    { 
                        Console.WriteLine("Invalid product");
                        command = Console.ReadLine();
                        continue;
                    }

                    if (totalMoney >= totalPrice)
                    {
                        totalMoney -= totalPrice;
                        Console.WriteLine($"Purchased {command.ToLower()}" );
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }

                    command = Console.ReadLine();
                }
            Console.WriteLine($"Change: {totalMoney:f2}");
        }
    }
}

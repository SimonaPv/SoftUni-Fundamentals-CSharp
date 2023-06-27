using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01.Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] commandArgs = Console.ReadLine()
                    .Split(' ');

                if (commandArgs[0] == "Close")
                {
                    return;
                }

                else if (commandArgs[0] == "Sell")
                {
                    string code = commandArgs[1];
                    double quantity = double.Parse(commandArgs[2]); 

                    Market.Sell(code, quantity);
                }

                else if (commandArgs[0] == "Add")
                {
                    string code = commandArgs[1];
                    string name = commandArgs[2];
                    double price = double.Parse(commandArgs[3]);
                    double quantity = double.Parse(commandArgs[4]);

                    Product product = new Product(code, name, price, quantity);
                    Market.Add(product);    
                }

                else if (commandArgs[0] == "Update")
                {
                    string code = commandArgs[1];
                    double quantity = double.Parse(commandArgs[2]);

                    Market.Update(code, quantity);
                }

                else if (commandArgs[0] == "PrintA")
                {
                    Market.PrintA();
                }

                else if (commandArgs[0] == "PrintU")
                {
                    Market.PrintU();
                }

                else if (commandArgs[0] == "PrintD")
                {
                    Market.PrintD();
                }

                else if (commandArgs[0] == "Calculate")
                {
                    Console.WriteLine(Market.Calculate());
                }

                else
                {
                    Console.WriteLine("Invalid command");
                }
            }
        }
    }
}

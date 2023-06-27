using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01.Burger_Bus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cities = int.Parse(Console.ReadLine());
            double fullIncome = 0;

            for (int i = 1; i <= cities; i++)
            {
                string cityName = Console.ReadLine();
                double income = double.Parse(Console.ReadLine());
                double expenses = double.Parse(Console.ReadLine());

                if (i % 3 != 0 && i % 5 != 0)
                {
                    income -= expenses;
                }
                
                else if (i % 3 == 0 && i % 5 != 0)
                {
                    income -= expenses;
                    expenses -= expenses * 0.5;
                    income -= expenses;
                }

                else if (i % 5 == 0 && i % 3 != 0)
                {
                    income = income - income * 0.1;
                    income = income - expenses;
                }

                fullIncome += income;
                Console.WriteLine($"In {cityName} Burger Bus earned {income:f2} leva.");
            }
            Console.WriteLine($"Burger Bus total profit: {fullIncome:f2} leva.");
        }
    }
}

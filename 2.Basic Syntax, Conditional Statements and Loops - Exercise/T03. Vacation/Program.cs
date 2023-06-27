using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string group = Console.ReadLine();   
            string day = Console.ReadLine();

            double price = 0;

            if (group == "Students")
            {
                if (day == "Friday")
                {
                    price = count * 8.45;
                }
                else if (day == "Saturday")
                {
                    price = count * 9.80;
                }
                else if (day == "Sunday")
                {
                    price = count * 10.46;
                }

                if (count >= 30)
                {
                    price -= price * 0.15;
                }
            }

            else if (group == "Business")
            {
                if (day == "Friday")
                {
                    price = count * 10.90;
                }
                else if (day == "Saturday")
                {
                    price = count * 15.60;
                }
                else if (day == "Sunday")
                {
                    price = count * 16;
                }

                if (count >= 100)
                {
                    price -= price / count * 10;
                }
            }

            else if (group == "Regular")
            {
                if (day == "Friday")
                {
                    price = count * 15;
                }
                else if (day == "Saturday")
                {
                    price = count * 20;
                }
                else if (day == "Sunday")
                {
                    price = count * 22.50;
                }

                if (count >= 10 && count <= 20)
                {
                    price -= price * 0.05;
                }
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}

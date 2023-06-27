using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03.Calculations
{
    internal class Program
    {
        static void Math(string action, int num1, int num2)
        {
            if (action == "add")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (action == "multiply")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (action == "subtract")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (action == "divide")
            {
                Console.WriteLine(num1 / num2);
            }
        }
        static void Main(string[] args)
        {
            string action = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());   

            Math(action, num1, num2);
        }
    }
}

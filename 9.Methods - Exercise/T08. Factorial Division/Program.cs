using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T08.Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Factorial(num1, num2);
        }
        static void Factorial(int num1, int num2)
        {
            double fact1 = 1;
            for (int i = num1; i > 0; i--)
            {
                fact1 *= num1;
                num1--;
            }

            double fact2 = 1;
            for (int i = num2; i > 0; i--)
            {
                fact2 *= num2;
                num2--;
            }

            double result = fact1 / fact2;
            Console.WriteLine($"{result:f2}");
        }
    }
}

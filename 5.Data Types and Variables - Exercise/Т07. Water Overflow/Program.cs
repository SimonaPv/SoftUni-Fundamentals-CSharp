using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Т07.Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int quantities = int.Parse(Console.ReadLine());
                sum += quantities;

                if (sum > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= quantities;
                }
            }
            Console.WriteLine(sum);
        }
    }
}

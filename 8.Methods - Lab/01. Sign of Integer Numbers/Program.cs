using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01.Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void NumType(int num)
        {
            if (num == 0)
            {
                Console.WriteLine($"The number {num} is zero.");
            }
            else if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            NumType(num);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T12.Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(num)}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an even number.");
                }
            }
    }
}

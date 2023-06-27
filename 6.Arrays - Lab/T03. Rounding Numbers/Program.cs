using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03.Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i]} => {(int)Math.Round(arr[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}

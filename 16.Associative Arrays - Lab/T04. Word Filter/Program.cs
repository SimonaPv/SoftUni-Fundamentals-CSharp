using System;
using System.Linq;

namespace T04._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ');

            string[] words = input
                .Where(x => x.Length % 2 == 0)
                .ToArray();

            Console.WriteLine(string.Join("\n", words));
        }
    }
}

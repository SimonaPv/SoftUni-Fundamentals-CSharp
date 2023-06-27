using System;
using System.Collections.Generic;
using System.Linq;

namespace T01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            double[] nums = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            foreach (var num in nums)
            {
                if (!counts.ContainsKey(num))
                {
                    counts.Add(num, 0);
                }

                counts[num]++;
            }

            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

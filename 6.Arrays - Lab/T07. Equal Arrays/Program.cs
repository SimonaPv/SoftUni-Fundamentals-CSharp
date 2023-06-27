using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T07.Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] first = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] second = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int sum = 0;

            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] != second[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }

                else
                {
                    sum += first[i];
                }
            }

            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}

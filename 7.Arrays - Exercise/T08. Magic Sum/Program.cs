using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T08.Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == sum)
                    {
                        Console.Write($"{nums[i]} {nums[j]}");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}

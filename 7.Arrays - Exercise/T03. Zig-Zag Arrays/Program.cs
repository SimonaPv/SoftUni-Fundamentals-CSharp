using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03.Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] evenIndex = new int[n];
            int[] oddIndex = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] nums = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 == 0)
                {
                    evenIndex[i] = nums[0];
                    oddIndex[i] = nums[1];
                }
                else
                {
                    evenIndex[i] = nums[1];
                    oddIndex[i] = nums[0];
                }
            }

            Console.WriteLine(String.Join(" ", evenIndex));
            Console.WriteLine(String.Join(" ", oddIndex));
        }
    }
}

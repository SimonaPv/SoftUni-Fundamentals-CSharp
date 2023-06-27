using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T06.Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int leftSum = 0;
            int rightSum = 0;   

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums.Length == 0)
                {
                    Console.WriteLine(0);
                    return;
                }

                leftSum = 0;
                for (int left = i; left > 0; left--)
                {
                    int nextElement = left - 1;
                    if (left > 0)
                    {
                        leftSum += nums[nextElement];
                    }
                }

                rightSum = 0;
                for (int right = i; right < nums.Length; right++)
                {
                    int nextElement = right + 1;
                    if (right < nums.Length - 1)
                    {
                        rightSum += nums[nextElement];
                    }
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(nums[i]);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}

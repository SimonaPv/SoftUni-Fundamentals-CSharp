using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05.Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int index = 0; index < nums.Length; index++)
            {
                bool bigger = true;

                for (int rightIndex = index + 1; rightIndex < nums.Length; rightIndex++)
                {
                    if (nums[index] <= nums[rightIndex])
                    {
                        bigger = false;
                        break;
                    }
                }

                if(bigger)
                {
                    Console.Write(nums[index] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}

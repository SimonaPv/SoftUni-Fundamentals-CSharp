using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04.Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                int tempElement = nums[0];

                for (int y = 0; y < nums.Length - 1; y++)
                {
                    nums[y] = nums[y + 1];
                }

                nums[nums.Length - 1] = tempElement;
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}

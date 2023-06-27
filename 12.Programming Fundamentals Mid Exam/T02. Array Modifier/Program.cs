using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02.Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] array = input.Split(' ');

                if (array[0] == "swap")
                {
                    Swap(int.Parse(array[1]), int.Parse(array[2]), nums);  
                }
                else if (array[0] == "multiply")
                {
                    Multiply(int.Parse(array[1]), int.Parse(array[2]), nums);
                }
                else if (array[0] == "decrease")
                {
                    Decrease(nums);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", nums));
        }
        
        static void Swap(int firstIndex, int secondIndex, List<int> nums)
        {
            int copy = nums[firstIndex];
             
            nums[firstIndex] = nums[secondIndex];
            nums[secondIndex] = copy;
        }

        static void Multiply(int firstIndex, int secondIndex, List<int> nums)
        {
            nums[firstIndex] *= nums[secondIndex];
        }

        static void Decrease(List<int> nums)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                nums[i]--;
            }
        }
    }
}

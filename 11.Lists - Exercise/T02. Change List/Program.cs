using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02.Change_List
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

                if (array[0] == "Delete")
                {
                    Delete(array, nums);
                }
                else if(array[0] == "Insert")
                {
                    nums.Insert(int.Parse(array[2]), int.Parse(array[1]));
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", nums));
        }

        static void Delete(string[] array, List<int> nums)
        {
            int num = int.Parse(array[1]);
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == num)
                {
                    nums.Remove(nums[i]);
                }
            }
        }
    }
}

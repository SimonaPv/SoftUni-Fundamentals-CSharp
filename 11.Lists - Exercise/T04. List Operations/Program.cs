using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04.List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();
            bool invalid = false;

            while (command != "End")
            {
                string[] tokens = command.Split(' ');

                if (tokens[0] == "Add")
                {
                    nums.Add(int.Parse(tokens[1]));
                }

                else if (tokens[0] == "Insert")
                {
                    int count = int.Parse(tokens[2]);
                    if (count > nums.Count - 1 || count < 0)
                    {
                        Console.WriteLine("Invalid index");
                        command = Console.ReadLine();
                        continue;
                    }
                    nums.Insert(count, int.Parse(tokens[1]));
                }

                else if (tokens[0] == "Remove")
                {
                    int count = int.Parse(tokens[1]);

                    if (count > nums.Count - 1 || count < 0)
                    {
                        Console.WriteLine("Invalid index");
                        command = Console.ReadLine();
                        continue;
                    }
                    nums.RemoveAt(count);
                }

                else if (tokens[1] == "left")
                {
                    ShiftLeft(tokens, nums);
                }

                else if (tokens[1] == "right")
                {
                    ShiftRight(tokens, nums);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", nums));
        }

        static void ShiftLeft(string[] array, List<int> nums)
        {
            int count = int.Parse(array[2]);
            for (int i = 0; i < count; i++)
            {
                nums.Add(nums[0]);
                nums.Remove(nums[0]);
            }
        }

        static void ShiftRight(string[] array, List<int> nums)
        {
            int count = int.Parse(array[2]);
            for (int i = 0; i < count; i++)
            {
                nums.Insert(0, nums[nums.Count - 1]);
                nums.RemoveAt(nums.Count - 1);
            }
        }
    }
}

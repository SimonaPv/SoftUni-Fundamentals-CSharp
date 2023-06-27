using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T06.List_Manipulation_Advanced
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
            bool changesMade = false;

            while (input != "end")
            {
                if (input == "end")
                {
                    break;
                }

                string[] array = input.Split(' ');

                if (array[0] == "Contains")
                {
                    if (nums.Contains(int.Parse(array[1])) == true)
                    {
                        Console.WriteLine("Yes");
                    }
                    else if (nums.Contains(int.Parse(array[1])) == false)
                    {
                        Console.WriteLine("No such number");
                    }
                }

                else if (array[0] == "PrintEven")
                {
                    PrintEven(nums);
                }

                else if (array[0] == "PrintOdd")
                {
                    PrintOdd(nums);
                }

                else if (array[0] == "GetSum")
                {
                    GetSum(nums);
                }

                else if (array[0] == "Filter")
                {
                    Filter(array, nums);
                }

                else if (array[0] == "Add")
                {
                    nums.Add(int.Parse(array[1]));
                    changesMade = true;
                }

                else if (array[0] == "Remove")
                {
                    nums.Remove(int.Parse(array[1]));
                    changesMade = true;
                }

                else if (array[0] == "RemoveAt")
                {
                    nums.RemoveAt(int.Parse(array[1]));
                    changesMade = true;
                }

                else if (array[0] == "Insert")
                {
                    nums.Insert(int.Parse(array[2]), int.Parse(array[1]));
                    changesMade = true;
                }

                input = Console.ReadLine();
            }

            if (changesMade == true)
            {
                Console.WriteLine(String.Join(" ", nums));
            }
        }

        static void PrintEven(List<int> nums)
        {
            List<int> evenNums = new List<int>();

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    evenNums.Add(nums[i]);
                }
            }
            Console.WriteLine(string.Join(" ", evenNums));
        }

        static void PrintOdd(List<int> nums)
        {
            List<int> oddNums = new List<int>();

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    oddNums.Add(nums[i]);
                }
            }
            Console.WriteLine(string.Join(" ", oddNums));
        }

        static void GetSum(List<int> nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                sum += nums[i];
            }

            Console.WriteLine(sum);
        }

        static void Filter(string[] array, List<int> nums)
        {
            int num = int.Parse(array[2]);
            if (array[1] == ">")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] > num)
                    {
                        Console.Write(nums[i] + " ");
                    }
                }
            }
            else if (array[1] == "<")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] < num)
                    {
                        Console.Write(nums[i] + " ");
                    }
                }
            }
            else if (array[1] == ">=")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] >= num)
                    {
                        Console.Write(nums[i] + " ");
                    }
                }
            }
            else if (array[1] == "<=")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] <= num)
                    {
                        Console.Write(nums[i] + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}

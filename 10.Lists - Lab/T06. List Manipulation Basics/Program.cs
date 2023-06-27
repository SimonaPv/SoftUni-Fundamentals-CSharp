using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T06.List_Manipulation_Basics
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
                if (input == "end")
                {
                    break;
                }

                string[] array = input.Split(' ');

                if (array[0] == "Add")
                {
                    nums.Add(int.Parse(array[1]));
                }
                else if (array[0] == "Remove")
                {
                    nums.Remove(int.Parse(array[1]));
                }
                else if (array[0] == "RemoveAt")
                {
                    nums.RemoveAt(int.Parse(array[1]));
                }
                else if (array[0] == "Insert")
                {
                    nums.Insert(int.Parse(array[2]), int.Parse(array[1]));
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", nums));
        }
    }
}

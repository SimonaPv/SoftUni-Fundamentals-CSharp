﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05.Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            nums.RemoveAll(n => n < 0);
            nums.Reverse();

            if (nums.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(String.Join(" ", nums));
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T09.Chars_to_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());   
            char third = char.Parse(Console.ReadLine());

            Console.WriteLine($"{first}{second}{third}");
        }
    }
}

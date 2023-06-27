using System;
using System.Collections.Generic;

namespace T05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] course = input.Split(" : ");
                string corseName = course[0];
                string personName = course[1];

                if (!courses.ContainsKey(corseName))
                {
                    courses.Add(corseName, new List<string>());
                }
                courses[corseName].Add(personName);

                input = Console.ReadLine();
            }

            foreach (var item in courses)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");

                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($"-- {string.Join("\n", item2)}");
                }

                
            }
        }
    }
}

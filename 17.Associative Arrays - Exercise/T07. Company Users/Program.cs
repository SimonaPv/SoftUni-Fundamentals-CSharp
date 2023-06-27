using System;
using System.Collections.Generic;
using System.Linq;

namespace T07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] company = input.Split(" -> ");

                if (!companies.ContainsKey(company[0]))
                {
                    companies.Add(company[0], new List<string>());
                }

                if (companies[company[0]].Contains(company[1]))
                {
                    input = Console.ReadLine();
                    continue;
                }

                companies[company[0]].Add(company[1]);

                input = Console.ReadLine();
            }

            foreach (var item in companies)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($"-- {string.Join("\n", item2)}");
                }
            }
        }
    }
}

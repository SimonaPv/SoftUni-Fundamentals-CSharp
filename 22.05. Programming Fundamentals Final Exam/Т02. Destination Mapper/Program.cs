using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Т02._Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(=|/)(?<place>[A-Z][A-Za-z]{2,})(\1)";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            List<string> list = new List<string>();

            foreach (Match item in matches)
            {
                string city = item.Groups["place"].Value;
                list.Add(city);
            }

            Console.WriteLine($"Destinations: {string.Join(", ", list)}");

            int sum = 0;

            foreach (var item in list)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    sum++;
                }
            }

            Console.WriteLine($"Travel Points: {sum}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace T02._Mirror_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([@#])(?<first>[A-Za-z]{3,})\1\1(?<second>[A-Za-z]{3,})\1";
            Dictionary<string, string> words = new Dictionary<string, string>();

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                string first = match.Groups["first"].Value;
                string second = match.Groups["second"].Value;
                string reversed = string.Join("", second.ToCharArray().Reverse().ToArray());

                if (first == reversed)
                {
                    words.Add(first, second); 
                }
            }

            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }

            if (words.Count == 0)
            {
                Console.WriteLine($"No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", words.Select(x => $"{x.Key} <=> {x.Value}")));
            }
        }
    }
}

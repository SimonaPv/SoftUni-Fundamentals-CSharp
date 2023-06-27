using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace T02._Emoji_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patternForEmojis = @"(\*{2}|:{2})(?<emoji>[A-Z][a-z]{2,})\1";
            string patternForNums = @"\d";

            string input = Console.ReadLine();

            MatchCollection emojiMatches = Regex.Matches(input, patternForEmojis);
            MatchCollection numbersMatches = Regex.Matches(input, patternForNums);

            long threshold = 1;
            foreach (Match num in numbersMatches)
            {
                threshold *= int.Parse(num.Value);
            }

            Console.WriteLine($"Cool threshold: {threshold}");
            Console.WriteLine($"{numbersMatches.Count} emojis found in the text. The cool ones are:");

            foreach (Match emoji in emojiMatches)
            {
                string emojiLetters = emoji.Groups["emoji"].Value;
                long sum = emojiLetters.ToCharArray().Sum(c => c);

                if (sum >= threshold)
                {
                    Console.WriteLine(emoji.Value);
                }
            }
        }
    }
}

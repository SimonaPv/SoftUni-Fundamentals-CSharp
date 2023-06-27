using System;
using System.Text.RegularExpressions;

namespace T02._Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\||#)(?<food>[A-Z][a-z]+\s*[A-Z]*[a-z]*)(\1)(?<date>\d{2}/\d{2}/\d{2})(\1)(?<calories>\d+)(\1)";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);int count = matches.Count;

            int sumOfCalories = 0;

            foreach (Match match in matches)
            {
                int calories = int.Parse(match.Groups["calories"].Value);
                sumOfCalories += calories;
            }

            int days = sumOfCalories / 2000;

            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (Match match in matches)
            {
                string food = match.Groups["food"].Value;
                string date = match.Groups["date"].Value;
                string calories = match.Groups["calories"].Value;

                Console.WriteLine($"Item: {food}, Best before: {date}, Nutrition: {calories}");
            }

        }
    }
}

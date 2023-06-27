using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace T02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex patternForName = new Regex(@"(?<names>[A-Za-z]+)");
            Regex patternForKm = new Regex (@"(?<nums>\d+)");
            int sumOfDigits = 0;

            List<string> names = Console.ReadLine()
                .Split(", ")
                .ToList();
            Dictionary<string, int> participants = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                MatchCollection matchesForName = patternForName.Matches(input);
                MatchCollection matchesForKm = patternForKm.Matches(input);

                string currName = string.Join("", matchesForName);
                string currKm = string.Join("", matchesForKm);

                sumOfDigits = 0;
                for (int i = 0; i < currKm.Length; i++)
                {
                    sumOfDigits += int.Parse(currKm[i].ToString());
                }

                if (names.Contains(currName))
                {
                    if (!participants.ContainsKey(currName))
                    {
                        participants.Add(currName, sumOfDigits);
                    }
                    else
                    {
                        participants[currName] += sumOfDigits;
                    }
                }

                input = Console.ReadLine();
            }

            var winners = participants.OrderByDescending(x => x.Value).Take(3);
            var first = winners.Take(1);
            var second = winners.OrderByDescending(x => x.Value).Take(2).OrderBy(x => x.Value).Take(1);
            var third = winners.OrderBy(x => x.Value).Take(1);

            foreach (var item in first)
            {
                Console.WriteLine($"1st place: {item.Key}");
            }

            foreach (var item in second)
            {
                Console.WriteLine($"2nd place: {item.Key}");
            }

            foreach (var item in third)
            {
                Console.WriteLine($"3rd place: {item.Key}");
            }
        }
    }
}

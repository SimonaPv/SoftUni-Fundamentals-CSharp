using System;
using System.Collections.Generic;
using System.Linq;

namespace T01._Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToCharArray();

            Dictionary<char, int> lettersCount = new Dictionary<char, int>();

            foreach (var letter in word)
            {
                if (letter != ' ')
                {
                    if (!lettersCount.ContainsKey(letter))
                    {
                        lettersCount.Add(letter, 0);
                    }
                    lettersCount[letter]++;
                }
            }

            foreach (var letter in lettersCount)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}

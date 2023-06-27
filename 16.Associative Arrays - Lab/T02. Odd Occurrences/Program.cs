using System;
using System.Collections.Generic;

namespace T02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .ToLower()
                .Split(' ');    

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!wordsCount.ContainsKey(word))
                {
                    wordsCount.Add(word, 0);
                }

                wordsCount[word]++; 
            }

            foreach (var word in wordsCount)
            {
                if (word.Value % 2 != 0)
                {
                    Console.Write(word.Key + " ");
                }
            }
        }
    }
}

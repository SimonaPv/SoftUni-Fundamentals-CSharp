using System;

namespace T03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine();
            string word = Console.ReadLine();

            while (word.Contains(wordToRemove))
            {
                int startIndex = word.IndexOf(wordToRemove);     
                word = word.Remove(startIndex, wordToRemove.Length);
            }

            Console.WriteLine(word);
        }
    }
}

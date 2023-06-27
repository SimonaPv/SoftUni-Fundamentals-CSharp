using System;

namespace T04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] censored = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var censoredWord in censored)
            {
                string stars = new string('*', censoredWord.Length);
                text = text.Replace(censoredWord, stars);
            }

            Console.WriteLine(text);
        }
    }
}

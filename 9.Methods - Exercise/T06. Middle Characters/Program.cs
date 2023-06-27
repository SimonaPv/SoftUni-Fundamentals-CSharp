using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T06.Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            MiddleLetter(word);
        }
        static void MiddleLetter(string word)
        {
            string letter = "";

            if (word.Length % 2 != 0)
            {
                letter = word[word.Length / 2].ToString();
            }
            else
            {
                letter += word[word.Length / 2 - 1];
                letter += word[word.Length / 2];
            }
            Console.WriteLine(letter);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02.Vowels_Count
{
    internal class Program
    {
        static void VowelsCount(string word)
        {
            Console.WriteLine(word.Count(vowel => "aoueiy".Contains(vowel)));
        }
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            VowelsCount(word);  
        }
    }
}

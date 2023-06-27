using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T07.Repeat_String
{
    internal class Program
    {
        static string Words(string word, int repeat)
        {
            string newWord = "";
            for (int i = 0; i < repeat; i++)
            {
                newWord += word;
            }
            return newWord;
        }
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());
            Console.WriteLine(Words(word, repeat));
        }
    }
}

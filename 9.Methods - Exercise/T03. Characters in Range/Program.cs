using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03.Characters_in_Range
{
    internal class Program
    {
        static void Chars(char letter1, char letter2)
        {
            int starsLetter = Math.Min(letter1, letter2);
            int endLetter = Math.Max(letter1, letter2);

            for (int i = starsLetter + 1; i < endLetter; i++)
            {
                Console.Write((char)i + " ");
            }
        }
        static void Main(string[] args)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());  
            Chars(letter1, letter2);
        }
    }
}

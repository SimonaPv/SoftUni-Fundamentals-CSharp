using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.Longest_palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string letters = Console.ReadLine();
            int maxLength = 0;

            for (int i = 0; i < letters.Length; i++)
            {
                maxLength = Math.Max(maxLength, PalindromeLen(i, i));
            }

            for (int i = 0; i < letters.Length - 1; i++)
            {
                maxLength = Math.Max(maxLength, PalindromeLen(i, i + 1));
            }
            Console.WriteLine(maxLength);

            int PalindromeLen(int left, int right)
            {
                while (left >= 0 && right < letters.Length && letters[left] == letters[right])
                {
                    left--;
                    right++;
                }
                return right - left - 1;
            }
        }
    }
}

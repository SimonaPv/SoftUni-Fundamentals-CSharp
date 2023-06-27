using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T09.Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                Console.WriteLine(IsPalindrome(input));   
                input = Console.ReadLine();
            }
        }

        static bool IsPalindrome(string input)
        {
            int num = int.Parse(input);

            if (num >= 0 && num <= 9)
            {
                return true;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == input[input.Length - 1])
                {
                    return true;
                }
                else { return false; }
            }  
            return false;
        }
    }
}

using System;
using System.Text;

namespace T05._Digits__Letters_and_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder chars = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder nums = new StringBuilder();

            foreach (char ch in input)
            {
                if (char.IsDigit(ch))
                {
                    nums.Append(ch);
                }
                else if (char.IsLetter(ch))
                {
                    letters.Append(ch);
                }
                else
                {
                    chars.Append(ch);
                }
            }

            Console.WriteLine(nums);
            Console.WriteLine(letters);
            Console.WriteLine(chars);
        }
    }
}

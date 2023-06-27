using System;

namespace T04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string text = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                text += (char)(input[i] + 3);
            }

            Console.WriteLine(text);
        }
    }
}

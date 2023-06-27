using System;
using System.Text.RegularExpressions;

namespace exam02._Message_Translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"!(?<command>[A-Z][a-z]{2,})!:\[(?<string>[A-Za-z]{8,})\]";

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match match = Regex.Match(input, pattern);

                if (!match.Success)
                {
                    Console.WriteLine("The message is invalid");
                }

                else
                {
                    string command = match.Groups["command"].Value;
                    string text = match.Groups["string"].Value;

                    int ascii = 0;

                    Console.Write($"{command}:");
                    for (int j = 0; j < text.Length; j++)
                    {
                        ascii = text[j];
                        Console.Write(" " + ascii);
                        ascii = 0;
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

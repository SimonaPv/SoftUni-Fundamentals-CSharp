using System;
using System.Text.RegularExpressions;

namespace T01._Match_Full_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b([A-Z][a-z]+) ([A-Z][a-z]+)\b";
            string names = Console.ReadLine();

            MatchCollection result = Regex.Matches(names, pattern);

            foreach (Match match in result)
            {
                Console.Write(match.Value + " ");
            }
            Console.WriteLine();
        }
    }
}

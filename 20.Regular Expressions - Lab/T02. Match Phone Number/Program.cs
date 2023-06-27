using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace T02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359( |-)2(\1)(\d{3})(\1)(\d{4})\b";
            string text = Console.ReadLine();

            MatchCollection phones = Regex.Matches(text, pattern);

            Console.WriteLine(string.Join(", ", phones));
        }
    }
}

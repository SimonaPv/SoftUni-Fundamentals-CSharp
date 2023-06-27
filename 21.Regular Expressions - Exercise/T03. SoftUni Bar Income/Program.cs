using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace T03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>[\w]+)>[^|$%.]*\|(?<quantity>[\d]+)\|[^|$%.]*?(?<price>[\d]+.?[\d]+)?\$";
            double totalPrice = 0;

            string input = Console.ReadLine();

            while (input != "end of shift")
            {
                Regex regex = new Regex(pattern);   
                bool success = regex.IsMatch(input);    

                if (success)
                {
                    string name = regex.Match(input).Groups["name"].Value;
                    string product = regex.Match(input).Groups["product"].Value;
                    double quantity = int.Parse(regex.Match(input).Groups["quantity"].Value) * double.Parse(regex.Match(input).Groups["price"].Value);

                    totalPrice += quantity;

                    Console.WriteLine($"{name}: {product} - {quantity:f2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalPrice:f2}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace T02._Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string barcodePattern = @"(@#+)(?<code>[A-Z][A-Za-z0-9]{4,}[A-Z])(@#+)";
            string digitsPattern = @"\d";

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string barcode = Console.ReadLine();

                Match barcodeMatch = Regex.Match(barcode, barcodePattern);
                MatchCollection digitsMatch = Regex.Matches(barcode, digitsPattern);

                if (barcodeMatch.Success)
                {
                    if (digitsMatch.Count > 0)
                    {
                        string digitMatches = "";
                        foreach (Match digit in digitsMatch)
                        {
                            digitMatches += digit.Value;
                        }

                        Console.WriteLine($"Product group: {digitMatches}");
                    }

                    else
                    {
                        Console.WriteLine("Product group: 00");
                    }
                }

                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}

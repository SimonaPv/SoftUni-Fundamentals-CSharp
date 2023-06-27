using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T06.Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int l = 0; l < n; l++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        char firstChar = (char)('a' + i);
                        char secondChar = (char)('a' + l);
                        char thirdChar = (char)('a' + j);
                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}

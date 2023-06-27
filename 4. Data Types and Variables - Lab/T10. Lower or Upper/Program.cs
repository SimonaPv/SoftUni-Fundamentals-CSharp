using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T10.Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch = char.Parse(Console.ReadLine());

            if (char.IsUpper(ch))
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}

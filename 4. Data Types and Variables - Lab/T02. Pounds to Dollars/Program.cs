using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02.Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pounds = double.Parse(Console.ReadLine());
            double dollars = pounds * 1.31;
            Console.WriteLine($"{dollars:f3}");
        }
    }
}

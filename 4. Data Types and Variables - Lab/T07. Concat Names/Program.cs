using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T07.Concat_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string sign = Console.ReadLine();

            Console.WriteLine($"{firstName}{sign}{lastName}");
        }
    }
}

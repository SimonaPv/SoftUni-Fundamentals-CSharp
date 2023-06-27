using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T06.Foreign_Languages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            if (name == "England" || name == "USA")
            {
                Console.WriteLine("English");
            }
            else if (name == "Spain" || name == "Argentina" || name == "Mexico")
            {
                Console.WriteLine("Spanish");
            }
            else { Console.WriteLine("unknown");  }
        }
    }
}

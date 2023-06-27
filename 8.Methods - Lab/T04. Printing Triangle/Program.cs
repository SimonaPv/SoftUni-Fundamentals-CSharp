using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04.Printing_Triangle
{
    internal class Program
    {
        static void Triangle(int start, int end)
        {
            for (int i = start; i <= end ; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i < num; i++)
            {
                Triangle(1, i);
            }
            for (int i = num; i >= 1; i--)
            {
                Triangle(1, i);
            }
        }
    }
}

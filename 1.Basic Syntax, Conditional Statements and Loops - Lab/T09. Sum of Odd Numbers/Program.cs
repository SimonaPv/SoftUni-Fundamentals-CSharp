using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T09.Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int all = 1;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(all);
                sum += all;
                all += 2;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}

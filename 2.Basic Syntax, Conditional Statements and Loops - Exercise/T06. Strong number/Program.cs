using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T06.Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int copy = num;
            int sum = 0;

            while (num > 0)
            {
                int fact = 1;
                int currNum = num % 10;
                num = num / 10;

                for (int i = 2; i <= currNum; i++)
                {
                    fact *= i;
                }
                sum += fact;
            }
            Console.WriteLine(sum == copy ? "yes" : "no");
        }
    }
}

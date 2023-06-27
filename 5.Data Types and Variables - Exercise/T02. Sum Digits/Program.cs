using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02.Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            while (num != 0)
            {
                for (int i = 0; i <= num; i++)
                {
                    int digit = num % 10;
                    num /=  10;
                    sum += digit;
                }
            }
            Console.WriteLine(sum);
        }
    }
}

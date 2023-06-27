using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T11.Math_operations
{
    internal class Program
    {
        static double Calculations(int num, string sign, int num2)
        {
            double result = 0;  

            if (sign == "/")
            {
                result = num / num2;
            }
            else if (sign == "*")
            {
                result = num * num2;
            }
            else if (sign == "+")
            {
                result = num + num2;
            }
            else if (sign == "-")
            {
                result = num - num2;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string sign = Console.ReadLine();   
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculations(num, sign, num2));
        }
    }
}

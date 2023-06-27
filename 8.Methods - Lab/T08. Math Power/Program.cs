using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T08.Math_Power
{
    internal class Program
    {
        static double MathPower(double num, int power)
        {
            double sum = Math.Pow(num, power);
            return sum;
        }
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(MathPower(num, power));
        }
    }
}

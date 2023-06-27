using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T06.Calculate_Rectangle_Area
{
    internal class Program
    {
        static double Area(double a, double b)
        {
            double area = a * b;
            return area;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Area(a, b));
        }
    }
}

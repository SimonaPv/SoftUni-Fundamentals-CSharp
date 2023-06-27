using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05.Add_and_Subtract
{
    internal class Program
    {
        static int FirstMethod(int num1, int num2)
        {
            return num1 + num2; 
        }
        static int SecondMethod(int num3)
        {
            return num3;
        }
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(FirstMethod(num1, num2) - SecondMethod(num3));
        }
    }
}

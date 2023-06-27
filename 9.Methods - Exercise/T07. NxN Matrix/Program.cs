using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T07.NxN_Matrix
{
    internal class Program
    {
        static void Matrix(int num)
        {
            for (int cols = 0; cols < num; cols++)
            {
                for (int rows = 0; rows < num; rows++)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Matrix(num);
        }
    }
}

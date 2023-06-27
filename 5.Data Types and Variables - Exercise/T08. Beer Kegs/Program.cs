using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T08.Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string theBiggestModel = "";
            double theBiggest = 0;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * radius * radius * height;

                if (volume >= theBiggest)
                {
                     theBiggestModel = model;
                    theBiggest = volume;
                }
            }
            Console.WriteLine(theBiggestModel);
        }
    }
}

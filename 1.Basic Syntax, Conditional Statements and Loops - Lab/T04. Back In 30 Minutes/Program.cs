using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04.Back_In_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());

            int allMinutes = hours * 60 + mins + 30;
            
            if (allMinutes / 60 == 24)
            {
                int midnight = 0;
                Console.WriteLine($"{midnight}:{allMinutes % 60 :d2}");
            }
            else
            {
                Console.WriteLine($"{allMinutes / 60}:{allMinutes % 60 :d2}");
            }           
        }
    }
}

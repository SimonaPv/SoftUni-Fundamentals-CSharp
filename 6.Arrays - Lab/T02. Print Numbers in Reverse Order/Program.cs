using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02.Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] nums = new int[count];

            for (int i = 0; i < count; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            for (int i = count - 1; i >= 0; i--)
            {
                Console.Write($"{nums[i]} ");
            }
            
        }
    }
}

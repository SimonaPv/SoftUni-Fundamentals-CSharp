using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03.Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums1 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> nums2 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            if (nums1.Count > nums2.Count)
            {
                for (int i = 0; i < nums2.Count; i++)
                {
                    Console.Write($"{nums1[i]} {nums2[i]} ");
                }

                for (int i = nums2.Count; i < nums1.Count; i++)
                {
                    Console.Write($"{nums1[i]} ");
                }
            }

            else
            {
                for (int i = 0; i < nums1.Count; i++)
                {
                    Console.Write($"{nums1[i]} {nums2[i]} ");
                }

                for (int i = nums1.Count; i < nums2.Count; i++)
                {
                    Console.Write($"{nums2[i]} ");
                }
            }
        }
    }
}

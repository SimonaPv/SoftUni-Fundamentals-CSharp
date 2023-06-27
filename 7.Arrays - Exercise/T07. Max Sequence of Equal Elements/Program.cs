using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T07.Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split().Select(int.Parse)
                .ToArray();
            string longestSequence = string.Empty;
            string currentSequence = string.Empty;
            int longestSequenceCount = 0;
            int currentSequenceCount = 1;
 
            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    if (currentSequenceCount == 1)
                    {
                        currentSequence = nums[i].ToString() + " ";
                    }
 
                    currentSequenceCount++;
                    currentSequence += nums[i] + " ";
                }
                else
                {
                    currentSequenceCount = 1;
                    currentSequence = nums[i].ToString() + " ";
                }
 
                if (currentSequenceCount > longestSequenceCount)
                {
                    longestSequenceCount = currentSequenceCount;
                    longestSequence = currentSequence;
                }
            }
 
            Console.WriteLine(longestSequence);

        }
    }
}

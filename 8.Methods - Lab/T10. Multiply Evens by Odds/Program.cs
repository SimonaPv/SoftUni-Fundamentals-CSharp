using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T10.Multiply_Evens_by_Odds
{
    internal class Program
    {
        static int GetSumOfEvenDigits(int num)
        {
            int sum = 0;
            int digits = num;

            while (digits > 0)
            {
                int currDigit = digits % 10;
                if (currDigit % 2 == 0)
                {
                    sum += currDigit;
                }
                digits /= 10;
            }
            return sum;
        }

        static int GetSumOfOddDigits(int num)
        {
            int sum = 0;
            int digits = num;

            while (digits > 0)
            {
                int currDigit = digits % 10;
                if (currDigit % 2 != 0)
                {
                    sum += currDigit;
                }
                digits /= 10;
            }
            return sum;
        }

        static int GetMultipleOfEvenAndOdds(int evenSum, int oddSum)
        {
            return evenSum * oddSum;
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int num = Math.Abs(number);

            int evenSum = GetSumOfEvenDigits(num);
            int oddSum = GetSumOfOddDigits(num);
            int sum = GetMultipleOfEvenAndOdds(evenSum, oddSum);

            Console.WriteLine(sum);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T07.Theatre_Promotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
  

            if (day == "weekday")
            {
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                {
                    Console.WriteLine("12$");
                }
                else if(age > 18 && age <= 64) 
                {
                    Console.WriteLine("18$");
                }
            }

            if (day == "weekend")
            {
                if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                {
                    Console.WriteLine("15$");
                }
                else if (age > 18 && age <= 64)
                {
                    Console.WriteLine("20$");
                }
            }

            if (day == "holiday")
            {
                if (age >= 0 && age <= 18)
                {
                    Console.WriteLine("5$");
                }
                else if (age > 18 && age <= 64)
                {
                    Console.WriteLine("12$");
                }
                else if (age > 64 && age <= 122)
                {
                    Console.WriteLine("10$");
                }
            }

            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] people = new int[count];

            int sum = 0;

            for (int i = 0; i < people.Length; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
                sum += people[i];
            }

            for (int i = 0; i < people.Length; i++)
            {
                Console.Write(people[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}

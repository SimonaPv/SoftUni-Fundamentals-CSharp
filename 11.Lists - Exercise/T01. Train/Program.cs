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
            List<int> wagons = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();
            int max = int.Parse(input);
            
            while (input != "end")
            {
                string[] method = input.Split(' ');

                if (method[0] == "Add")
                {
                    wagons.Add(int.Parse(method[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int people = int.Parse(method[0]);
                        if (wagons[i] + people <= max)
                        {
                            wagons[i] += people;
                            break;
                        }
                    }
                }
                input = Console.ReadLine(); 
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}

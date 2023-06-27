using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03.House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            List<string> person = new List<string>();

            for (int i = 0; i < people; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(' ');

                if (person.Contains(command[0]) && command[2] == "going!")
                {
                    Console.WriteLine($"{command[0]} is already in the list!");
                }
                else if (person.Contains(command[0]) && command[2] != "going!")
                {
                    person.Remove(command[0]);
                }
                else if (!person.Contains(command[0]) && command[2] != "going!")
                {
                    Console.WriteLine($"{command[0]} is not in the list!");
                }
                else
                {
                    person.Add(command[0]);
                }
            }
            Console.WriteLine(String.Join("\n", person));
        }
    }
}

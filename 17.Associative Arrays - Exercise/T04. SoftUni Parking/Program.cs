using System;
using System.Collections.Generic;

namespace T04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> people = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] person = Console.ReadLine().Split();

                if (person[0] == "register")
                {
                    if (!people.ContainsKey(person[1]))
                    {
                        people.Add(person[1], person[2]);
                        Console.WriteLine($"{person[1]} registered {person[2]} successfully");
                    }
                    else if(people.ContainsKey(person[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {person[2]}");
                    }
                }

                if (person[0] == "unregister")
                {
                    if (people.ContainsKey(person[1]))
                    {
                        people.Remove(person[1]);
                        Console.WriteLine($"{person[1]} unregistered successfully");
                    }
                    else if(!people.ContainsKey(person[1]))
                    {
                        Console.WriteLine($"ERROR: user {person[1]} not found");
                    }
                }
            }

            foreach (var item in people)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}

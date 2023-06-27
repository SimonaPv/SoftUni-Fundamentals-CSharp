using System;

namespace T01._World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Travel")
            {
                string[] command = input.Split(":");

                if (command[0] == "Add Stop")
                {
                    int index = int.Parse(command[1]);

                    if (index >= 0 && index < stops.Length)
                    {
                        stops = stops.Insert(int.Parse(command[1]), command[2]);
                    }

                    Console.WriteLine(stops);
                }

                else if (command[0] == "Remove Stop")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    if (startIndex >= 0 && startIndex < stops.Length && endIndex >= 0 && endIndex < stops.Length)
                    {
                        stops = stops.Remove(startIndex, endIndex + 1 - startIndex);
                    }

                    Console.WriteLine(stops);
                }

                else if (command[0] == "Switch")
                {
                    string oldS = command[1];
                    string newS = command[2];

                    if (stops.Contains(oldS))
                    {
                        stops = stops.Replace(oldS, newS);
                    }

                    Console.WriteLine(stops);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}

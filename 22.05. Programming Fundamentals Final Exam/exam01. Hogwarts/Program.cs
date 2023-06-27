using System;
using System.Linq;

namespace exam01._Hogwarts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Abracadabra")
            {
                string[] command = input.Split();

                if (command[0] == "Abjuration")
                {
                    text = text.ToUpper();
                    Console.WriteLine(text);
                }

                else if (command[0] == "Necromancy")
                {
                    text = text.ToLower();
                    Console.WriteLine(text);
                }

                else if (command[0] == "Illusion")
                {
                    int index = int.Parse(command[1]);
                    char letter = char.Parse(command[2]);

                    if (index >= 0 && index < text.Length)
                    {
                        char[] illusion = text.ToCharArray();
                        illusion[index] = letter;

                        string ill = string.Empty;

                        foreach (var item in illusion)
                        {
                            ill += item;
                        }

                        text = ill;
                        Console.WriteLine("Done!");
                    }
                    else
                    {
                        Console.WriteLine("The spell was too weak.");
                    }
                }

                else if (command[0] == "Divination")
                {
                    if (text.Contains(command[1]))
                    {
                        text = text.Replace(command[1], command[2]);
                        Console.WriteLine(text);
                    }
                }

                else if (command[0] == "Alteration")
                {
                    if (text.Contains(command[1]))
                    {
                        text = text.Remove(text.IndexOf(command[1]), command[1].Length);
                        Console.WriteLine(text);
                    }
                }

                else
                {
                    Console.WriteLine("The spell did not work!");
                }

                input = Console.ReadLine();
            }
        }
    }
}

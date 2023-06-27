using System;
using System.Collections.Generic;

namespace T03._The_Pianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Pianists> pianists = new Dictionary<string, Pianists>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] pieces = Console.ReadLine().Split("|");
                pianists.Add(pieces[0], new Pianists(pieces[1], pieces[2]));    
            }

            string input = Console.ReadLine();

            while (input != "Stop")
            {
                string[] command = input.Split("|");
                string piece = command[1];

                if (command[0] == "Add")
                {
                    if (!pianists.ContainsKey(piece))
                    {
                        pianists.Add(piece, new Pianists(command[2], command[3]));
                        Console.WriteLine($"{piece} by {command[2]} in {command[3]} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }

                else if (command[0] == "Remove")
                {
                    if (!pianists.ContainsKey(piece))
                    {
                        Console.WriteLine($"Invalid operation! { piece} does not exist in the collection.");
                    }
                    else
                    {
                        pianists.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                }

                else if (command[0] == "ChangeKey")
                {
                    if (!pianists.ContainsKey(piece))
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                    else
                    {
                        //string composer = pianists[piece].Composer;
                        //string key = pianists[piece].Key;

                        //pianists.Remove(piece);
                        //pianists.Add(command[2], new Pianists(composer, key));

                        pianists[piece].Key = command[2];

                        Console.WriteLine($"Changed the key of {piece} to {command[2]}!");
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var item in pianists)
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value.Composer}, Key: {item.Value.Key}");
            }
        }
    }
    class Pianists
    {
        public Pianists(string composer, string key)
        {
            this.Composer = composer;
            this.Key = key;
        }
        public string Composer { get; set; }
        public string Key { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace exam03._Followers
{
    class Followers
    {
        public Followers(int likes, int comments)
        {
            this.Likes = likes;
            this.Comments = comments;
        }

        public int Likes { get; set; }
        public int Comments { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Followers> account = new Dictionary<string, Followers>();

            string input = Console.ReadLine();

            while (input != "Log out")
            {
                string[] command = input.Split(": ");

                if (command[0] == "New follower")
                {
                    if (!account.ContainsKey(command[1]))
                    {
                        account.Add(command[1], new Followers(0, 0));
                    }
                }

                else if (command[0] == "Like")
                {
                    if (!account.ContainsKey(command[1]))
                    {
                        account.Add(command[1], new Followers(int.Parse(command[2]), 0));
                    }
                    else
                    {
                        account[command[1]].Likes += int.Parse(command[2]);
                    }
                }

                else if (command[0] == "Comment")
                {
                    if (!account.ContainsKey(command[1]))
                    {
                        account.Add(command[1], new Followers(0, 1));
                    }
                    else
                    {
                        account[command[1]].Comments++;
                    }
                }

                else if (command[0] == "Blocked")
                {
                    if (!account.ContainsKey(command[1]))
                    {
                        Console.WriteLine($"{command[1]} doesn't exist.");
                    }
                    else
                    {
                        account.Remove(command[1]);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{account.Count} followers");
            foreach (var acc in account)
            {
                int sum = acc.Value.Likes + acc.Value.Comments;
                Console.WriteLine($"{acc.Key}: {sum}");
            }
        }
    }
}

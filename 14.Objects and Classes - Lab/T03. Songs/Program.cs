using System;
using System.Collections.Generic;

namespace T03._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Songs> songs = new List<Songs>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] songInfo = Console.ReadLine().Split('_');

                Songs song = new Songs(songInfo[0], songInfo[1], songInfo[2]);
                songs.Add(song);
            }

            string type = Console.ReadLine();

            if (type == "all")
            {
                foreach (Songs song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Songs song in songs)
                {
                    if (song.Type == type)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
    class Songs
    {
        public Songs(string type, string name, string time)
        {
            this.Type = type;
            this.Name = name;
            this.Time = time;
        }

        public string Type { get; set; }
        public string Name { get; set; }
        public string Time { set; get; }
    }
}

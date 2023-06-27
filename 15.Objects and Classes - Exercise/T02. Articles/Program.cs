using System;
using System.Collections.Generic;
using System.Linq;

namespace T02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ").ToList();
            int n = int.Parse(Console.ReadLine());

            Article article = new Article(input[0], input[1], input[2]);

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(": ");

                if (command[0] == "Edit")
                {
                    article.Edit(command[1]);
                }

                else if (command[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(command[1]);
                }

                else if (command[0] == "Rename")
                {
                    article.Rename(command[1]);
                }
            }

            Console.WriteLine(article.ToString());
        }
    }
    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void ChangeAuthor(string author)
        {
            Author = author;
        }
        public void Edit(string content)
        {
            Content = content;
        }
        public void Rename(string title)
        {
            Title = title;  
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}

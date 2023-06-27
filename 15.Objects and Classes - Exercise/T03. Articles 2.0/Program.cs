using System;
using System.Collections.Generic;
using System.Linq;

namespace T02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(", ");

                Article article = new Article(command[0], command[1], command[2]);
                articles.Add(article);
            }

            string line = Console.ReadLine();

            foreach (var article in articles)
            {
                Console.WriteLine(article);
            }
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

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}

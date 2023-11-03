using System;

namespace _02.Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();

            int commandCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandCount; i++)
            {
                string[] input = Console.ReadLine().Split(", ").ToArray();

                Article article = new Article(input[0], input[1], input[2]);

                articles.Add(article);
            }

            foreach (Article article in articles)
            {
                Console.WriteLine(article.ToString());
            }
        }
    }

    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
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
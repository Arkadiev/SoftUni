using System;

namespace _02.Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();

            Article article = new Article(input[0], input[1], input[2]);

            int commandCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandCount; i++)
            {
                string[] command = Console.ReadLine().Split(": ").ToArray();

                switch (command[0])
                {
                    case "Rename": article.Rename(command[1]); break;

                    case "Edit": article.Edit(command[1]); break;

                    case "ChangeAuthor": article.ChangeAuthor(command[1]); break;
                }
            }

            article.ToString();
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

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        public void ToString()
        {
            Console.WriteLine($"{Title} - {Content}: {Author}");
        }
    }
}
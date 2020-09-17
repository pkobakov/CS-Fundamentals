using System;
using System.Linq;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Console.ReadLine().
                        Split(", ", StringSplitOptions.RemoveEmptyEntries). // прочитане не първоначалните стойности; 
                        ToArray();

            string title = data[0];
            string content = data[1];
            string author = data[2];

            Article article = new Article(title, content, author); // създавам обект от клас Article с първоначaлните стойности;

            int commandsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < commandsCount; i++)
            {
                
                var command = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (command[0])
                {
                    case "Edit": article.Edit(command[1]); break;
                    case "ChangeAuthor": article.ChangeAuthor(command[1]); break;
                    case "Rename": article.Rename(command[1]); break;
                        
                }
            }
            Console.WriteLine(article.ToString());

        }
    }
    public class Article
    { 
           public string Title {get; set;}
           public string Content {get; set;}
           public string Author {get; set;}

        public Article(string title, string content, string  author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public void Edit(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void Rename(string newTitle) 
        {
            Title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";     
        }

    }
}

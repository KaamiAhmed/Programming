
namespace Assignment4
{
    internal class Book
    {
        public string title, author;


        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public void DisplayBookInfo()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
        }
    }
}

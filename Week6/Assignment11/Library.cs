
namespace Assignment11
{
    internal class Library
    {
        private List<string> _books;


        public Library()
        {
            _books = new List<string>();
        }

        public void AddBook(string bookName)
        {
            _books.Add(bookName);
            Console.WriteLine("\nBook added to the library.");
        }

        public void ListBooks()
        {
            Console.WriteLine("\nBooks in the library:");
            foreach (string book in _books)
            {
                Console.WriteLine(book);
            }
        }
    }
}

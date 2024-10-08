
namespace Assignment8
{
    internal class Library
    {
        //fields
        public Book[] books;
        public int countBooks;

        //constructor
        public Library(int capacity)
        {
            books = new Book[capacity];
            countBooks = 0;
        }

        // methods
        public void AddBook(Book book)
        {
            books[countBooks] = book;
            countBooks++;
        }

        public void DisplayBooks()
        {
           
            for (int i = 0; i < books.Length; i++)
            {
                books[i].DisplayBookInfo();
            }
        }
    }
}

namespace Assignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            
            Console.Write("How many books should there be in the library: ");
            int nrOfBooks = int.Parse(Console.ReadLine());

            Library library = new Library(nrOfBooks);

            Console.WriteLine();

            for (int i = 0; i < nrOfBooks; i++)
            {
                Console.Write("Enter book title: ");
                string title = Console.ReadLine();

                Console.Write("Enter book author: ");
                string author = Console.ReadLine();

                Book book = new Book(title, author);
                library.AddBook(book);

                Console.WriteLine();
            }

            Console.WriteLine("Books in library:");
            library.DisplayBooks();
        }
    }
}

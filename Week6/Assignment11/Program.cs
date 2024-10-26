namespace Assignment11
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
            Library library = new Library();

            Console.Write("Enter book name: ");
            string bookName = Console.ReadLine();

            library.AddBook(bookName);
            library.ListBooks();
        }
    }
}
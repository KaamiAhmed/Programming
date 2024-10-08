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
            string[] albums = new string[100];
            int numberOfAlbums = 0;

            while (numberOfAlbums < 100)
            {
                DisplayAlbums(albums, numberOfAlbums);

                Console.Write("Do you want to add another album? (yes/no): ");
                string response = Console.ReadLine();

                if (response == "yes")
                {
                    Console.Write($"Enter the name of album {numberOfAlbums + 1}: ");
                    albums[numberOfAlbums] = Console.ReadLine();
                    numberOfAlbums++;
                }
                else if (response == "no")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter \"yes\" or \"no\". ");
                }
            }

            Console.Write("Enter the name of the book you want to search for: ");
            string searchAlbum = Console.ReadLine();

            if (FindAlbum(albums, numberOfAlbums, searchAlbum))
            {
                Console.WriteLine($"The album \"{searchAlbum}\" is in your list.");
            }
            else
            {
                Console.WriteLine($"The album \"{searchAlbum}\" is not in your list.");
            }
        }

        void DisplayAlbums(string[] albums, int numberOfAlbums)
        {
            Console.WriteLine("Your favourite albums are:");
            for (int i = 0; i < numberOfAlbums; i++)
            {
                Console.WriteLine($"{i + 1}. {albums[i]} ");
            }
            Console.WriteLine();
        }

        bool FindAlbum(string[] albums, int numberOfAlbums, string
searchAlbum)
        {
            for (int i = 0; i < numberOfAlbums; i++)
            {
                if (albums[i] == searchAlbum)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

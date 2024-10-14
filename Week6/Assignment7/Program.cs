namespace Assignment7
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
            Console.Write("Enter Product name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Product price: ");
            double price = double.Parse(Console.ReadLine());

            Product product = new Product(name, price);

            Console.WriteLine("\nProduct details:");
            Console.WriteLine($"Name: {product.Name}");
            Console.WriteLine($"Price {product.Price}");
        }
    }
}

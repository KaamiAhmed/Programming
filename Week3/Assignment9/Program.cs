namespace Assignment9
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
            Console.Write("Enter the number of terms: ");
            int terms = int.Parse(Console.ReadLine());

            GenerateFibonacci(terms);
        }

        void GenerateFibonacci(int terms)
        {
            int a = 0, b = 1;
            Console.Write(b);
            for (int i = 1; i < terms; i++)
            {
                int c = a + b;
                Console.Write($" {c}");
                a = b;
                b = c;      
            }
        }
    }
}

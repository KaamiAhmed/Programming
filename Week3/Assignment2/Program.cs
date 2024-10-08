namespace Assignment2
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
            int number, factorial;

            Console.Write("Enter a non-negative integer: ");
            number = int.Parse(Console.ReadLine());

            factorial = CalculateFactorial(number);

            Console.WriteLine($"The factorial of {number} is: {factorial}");
        }

        int CalculateFactorial(int n)
        {
            int factorial = 1;
            for (int i = n; i > 0; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}

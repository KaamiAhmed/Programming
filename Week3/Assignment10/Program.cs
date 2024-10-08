namespace Assignment10
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
            Console.Write("Enter an integer: ");
            int integer = int.Parse(Console.ReadLine());

            int reverse = ReversedNumber(integer);

            Console.Write($"Reversed Number: {reverse}");
        }

        int ReversedNumber(int number)
        {
            int reverse = 0;
            while (number != 0)
            {
                int remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number /= 10;
            }

            return reverse;
        }

    }
}

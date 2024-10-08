namespace Assignment1
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
            int number, sum;

            Console.Write("Enter a positive integer: ");
            number = int.Parse(Console.ReadLine());

            sum = (CalculateSum(number));

            Console.WriteLine($"The sum of natural numbers from 1 to {number} is: {sum}");

        }

        int CalculateSum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
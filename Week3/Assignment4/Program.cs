using System.Diagnostics.Tracing;

namespace Assignment4
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
            int number1, number2;

            Console.Write("Enter the start of the range: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the end of the range: ");
            number2 = int.Parse(Console.ReadLine());

            (int evenCount, int oddCount) = CountEvenAndOdd(number1, number2);

            Console.WriteLine($"Between {number1} and {number2}:");
            Console.WriteLine($"Even numbers: {evenCount}");
            Console.WriteLine($"Odd numbers: {oddCount}");

        }

        (int evenCount, int oddCount) CountEvenAndOdd(int start, int end)
        {
            int evenCount = 0, oddCount = 0;

            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                   evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
            return (evenCount, oddCount);
        }
    }
}

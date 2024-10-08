using System.Reflection.Metadata.Ecma335;

namespace Assignment3
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
            int[] numbers = new int[3];

            FillArray(numbers);

            int sum = CalculateSum(numbers);

            double average = CalculateAverage(numbers);

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average:0.00}");
        }

        void FillArray(int[] numbers)
        {
            Console.WriteLine("Enter 3 integers: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
        }

        int CalculateSum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        double CalculateAverage(int[] numbers)
        {
            int sum = CalculateSum(numbers);
            double average = (double)sum/numbers.Length;
            return average;
        }
        
    }
}
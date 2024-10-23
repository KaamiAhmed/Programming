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
            Console.Write("Enter the number of elements: ");
            int count = int.Parse(Console.ReadLine());

            int sum = CalculateSum(count);
            double average = CalculateAverage(sum, count);

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average:0.00}");
        }

        int CalculateSum(int count)
        {
            int number, sum = 0;
            for (int i = 1; i <= count; i++)
            {
                Console.Write($"Enter number {i}: ");
                number = int.Parse(Console.ReadLine());

                sum += number;
            }
            return sum;
        }

        double CalculateAverage(int sum, int count)
        {
            double average = (double)sum / count;
            return average;
        }
    }
}

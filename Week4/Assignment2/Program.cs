namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        const int NrOfElements = 20, LowestValue = 1, HighestValue = 100;

        void Start()
        {
            int[] numbers = new int[NrOfElements];

            FillArray(numbers);
            DisplayArray(numbers);

            int smallestNumber = GetSmallestNumber(numbers);

            Console.WriteLine($"Smallest Number is : {smallestNumber}");
        }

        void FillArray(int[] numbers)
        {
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(LowestValue, HighestValue);
            }
        }

        void DisplayArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]:00} ");
            }
            Console.WriteLine();
        }

        int GetSmallestNumber(int[] numbers)
        {
            // lets assume
            int smallestNumber = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < smallestNumber)
                {
                    smallestNumber = numbers[i];
                }
            }
            return smallestNumber;
        }
    }
}

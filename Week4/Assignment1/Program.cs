namespace Assignment1
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
        }

        void FillArray(int[] numbers)
        {
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(LowestValue, HighestValue + 1);
            }
        }

        void DisplayArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Element {i + 1} is: {numbers[i]}");
            }
        }
    }
}

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
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            PrintMultiplicationTable(number);
        }

        void PrintMultiplicationTable(int number)
        {
            int multiplication = 0;
            for (int i = 1; i <= 10; i++)
            {
                multiplication = i * number;
                Console.WriteLine($"{i} x {number} = {multiplication}");
            }
        }
    }
}

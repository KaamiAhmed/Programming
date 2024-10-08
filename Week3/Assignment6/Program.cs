namespace Assignment6
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
            Console.Write("Enter a positive integer greater than 1: ");
            int number = int.Parse(Console.ReadLine());

            if (IsPrime(number))
            {
                Console.WriteLine($"The {number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"The {number} is not a prime number");
            }
        }

        bool IsPrime(int number)
        {
            for(int i = 2; i < number; i++)
            {
                if(number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

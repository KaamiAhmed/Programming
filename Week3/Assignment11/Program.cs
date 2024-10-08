namespace Assignment11
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
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int gcd = CalculateGCD(num1, num2);

            Console.WriteLine($"GCD of the numbers {num1} and {num2} is: {gcd}");
        }

        int CalculateGCD(int a, int b)
        {
            int remainder;
            while(b != 0)
            {
                remainder = a % b;
                a = b;
                b = remainder;
            }
            return a;
        }
    }
}

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        int choice, num1, num2;
        double result;

        void Start()
        {
            bool continuecalculation = true;

            while (continuecalculation)
            {
                DisplayMenu();

                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                if (choice == 5)
                {
                    continuecalculation = false;
                }
                else
                {
                    Console.Write("Enter first number: ");
                    num1 = int.Parse(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    num2 = int.Parse(Console.ReadLine());

                    PerformCalculation();
                }

            }
        }

        void PerformCalculation()
        {
            switch (choice)
            {

                case 1:
                    result = Add(num1, num2);
                    Console.WriteLine($"The answer is {result}");
                    break;
                case 2:
                    result = Subtract(num1, num2);
                    Console.WriteLine($"The answer is {result}");
                    break;
                case 3:
                    result = Multiply(num1, num2);
                    Console.WriteLine($"The answer is {result}");
                    break;
                case 4:
                    result = Divide(num1, num2);
                    Console.WriteLine($"The answer is {result:0.00}");
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }
        }

        int Add(int a, int b)
        {
            return a + b;
        }

        int Subtract(int a, int b)
        {
            return a - b;
        }

        int Multiply(int a, int b)
        {
            return a * b;
        }

        double Divide(int a, int b)
        {
            return (double)a / b;
        }

        void DisplayMenu()
        {
            Console.WriteLine("Simple calculator menu:");
            Console.WriteLine("1. Addition:");
            Console.WriteLine("2. Subtraction:");
            Console.WriteLine("3. Multiplication:");
            Console.WriteLine("4. Division:");
            Console.WriteLine("5. Exit:");
        }
    }
}


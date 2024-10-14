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
            Console.Write("Enter deposit amount: ");
            double depositAmount = double.Parse(Console.ReadLine());

            Account account = new Account("Kamran Ahmed");

            account.Deposit(depositAmount);

            Console.WriteLine("\nAccount Details:");
            account.DisplayAccountInfo();
        }
    }
}

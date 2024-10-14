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
            BankAccount bankAccount = new BankAccount("123456", 0);

            Console.Write("Enter deposit amount: ");
            double deposit = double.Parse(Console.ReadLine());
            bankAccount.Deposit(deposit);

            Console.Write("Enter withdrawal amount: ");
            double withdraw = double.Parse(Console.ReadLine());
            bankAccount.Withdraw(withdraw);

            Console.WriteLine("\nAccount Details:");
            Console.WriteLine($"Account number: {bankAccount.AccountNumber}");
            Console.WriteLine($"Balance: {bankAccount.Balance:0.00}");
        }
    }
}

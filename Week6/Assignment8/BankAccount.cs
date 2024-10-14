
namespace Assignment8
{
    internal class BankAccount
    {
        public string AccountNumber { get; set; }
        public double Balance { get; private set; }


        public BankAccount(string accountNumber, double initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine("Deposit Successful.\n");
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
            Console.WriteLine("Withdrawal Successful.");
        }
    }
}

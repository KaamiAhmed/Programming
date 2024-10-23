
namespace Assignment9
{
    internal class BankAccount
    {
        public int AccountNumber;
        public string HolderName;
        public double Balance;

        public BankAccount(string holderName, double initialBalance)
        {
            HolderName = holderName;
            Balance = initialBalance;
        }

        public void Deposit(int accountNumber, double amount)
        {
            Balance += amount;
            Console.WriteLine("\nSuccessfully deposited.");
        }

        public void Withdraw(int accountNumber, double amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                Balance -= amount;
            }
        }

        public void DisplayAccountDetails(int accountNumber)
        {
            Console.WriteLine("\nAccount Details: ");
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Account Holder: {HolderName}");
            Console.WriteLine($"Balance: {Balance}");
        }
    }
}
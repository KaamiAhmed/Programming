
namespace Assignment9
{
    internal class Bank
    {
        public BankAccount[] Accounts;
        public int accountCounter = 0;
         
        public Bank(int capacity)
        {
            Accounts = new BankAccount[capacity];
        }

        public void CreateAccount(string accountHolder)
        {
            if (accountCounter < Accounts.Length)
            {
                BankAccount newAccount = new BankAccount(accountHolder, 0);

                newAccount.AccountNumber = accountCounter + 1;

                Accounts[accountCounter] = newAccount;
                accountCounter++;

                Console.WriteLine($"\nAccount created with number: {newAccount.AccountNumber}");
            }
            else
            {
                Console.WriteLine("Bank is full.");
            }
        }
    }
}

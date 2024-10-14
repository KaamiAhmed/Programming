
namespace Assignment6
{
    internal class Account
    {
        private string _accountholder;
        private double _amount;

        public Account(string accountHolder)
        {
            _accountholder = accountHolder;
            _amount = 0;
        }

        public void Deposit(double amount)
        {
            _amount += amount;
            LogTransaction("Deposit Successful.");
        }

        private void LogTransaction(string message)
        {
            Console.WriteLine(message);
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Holder: {_accountholder}");
            Console.WriteLine($"Account Balance: {_amount}");
        }
    }
}

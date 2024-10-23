using System.Security.Principal;

namespace Assignment9
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
            Bank bank = new Bank(10);
            Console.Write("Enter account holder name: ");
            string holderName = Console.ReadLine();

            bank.CreateAccount(holderName);
            BankAccount bankAccount = new BankAccount(holderName, 0);

            Console.Write("\nEnter deposit amount: ");
            double depositAmount = double.Parse(Console.ReadLine());

            
            bankAccount.Deposit(1, depositAmount);

            bankAccount.DisplayAccountDetails(1);
        }
    }
}

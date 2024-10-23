using System.Transactions;

namespace Assignment2
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
            Console.Write("Enter a day of the week(e.g Monday): ");
            string input = Console.ReadLine();
            Day day = (Day)Enum.Parse(typeof(Day), input);

            switch (day)
            {
                case Day.Monday:
                case Day.Tuesday:
                case Day.Wednesday:
                case Day.Thursday:
                case Day.Friday:
                    Console.WriteLine($"Weekend is loading...");
                    break;
                case Day.Saturday:
                case Day.Sunday:
                    Console.WriteLine($"It's Weekend! Party time!");
                    break;
            }
        }
    }
}
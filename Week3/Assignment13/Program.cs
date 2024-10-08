namespace Assignment13
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
            int rndNumber = GenerateRandomNumber();
            PlayGuessingGame(rndNumber);
        }

        void PlayGuessingGame(int numberToGuess)
        {
            int attempts = 0, userInput = 0;
            
            while (userInput != numberToGuess)
            {
                Console.Write("Guess a number between 1 and 100: ");
                userInput = int.Parse(Console.ReadLine());
                attempts++;
                if (userInput < numberToGuess)
                {
                    Console.WriteLine("Too low. Try again.");
                }
                else if(userInput > numberToGuess)
                {
                    Console.WriteLine("Too high. Try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
                }
            }
        }

        int GenerateRandomNumber()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            return randomNumber;
        }
    }
}

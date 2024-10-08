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
            Console.Write("How many votes should be processed: ");
            int nrOfVotes = int.Parse(Console.ReadLine());
            VotingSystem votingsystem = new VotingSystem(nrOfVotes);
            Console.WriteLine();

            for (int i = 0; i < nrOfVotes; i++)
            {
                Console.Write("Enter your vote(yes/no): ");
                string input = Console.ReadLine();
                VoteOption vote = (VoteOption)Enum.Parse(typeof(VoteOption), input);
                if(vote == VoteOption.yes)
                {
                    votingsystem.CastVote(vote);
                    Console.WriteLine($"Vote casted: {vote}");
                }
                else if (vote == VoteOption.no)
                {
                    votingsystem.CastVote(vote);
                    Console.WriteLine($"Vote casted: {vote}");
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Results:");
            votingsystem.DisplayResults();
        }
    }
}

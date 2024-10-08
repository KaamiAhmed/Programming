
namespace Assignment6
{
    internal class VotingSystem
    {
        //fields
        public VoteOption[] votes;
        int index;


        //constructor
        public VotingSystem(int size)
        {
            votes = new VoteOption[size];
            index = 0;
        }


        //methods
        public void CastVote(VoteOption vote)
        {
                votes[index] = vote;
                index++;   
        }

        public void DisplayResults()
        {
            int yes = 0, no = 0;
            
            for (int i = 0; i < votes.Length; i++)
            {
                if (votes[i] == VoteOption.yes)
                {
                    yes++;
                }
                else
                {
                    no++;
                }
            }

            Console.WriteLine($"Yes: {yes}");
            Console.WriteLine($"No: {no}");
        }
    }
}

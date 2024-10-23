namespace Assignment10
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
            Quiz quiz = new Quiz(3);

            quiz.AddQuestion(new Question("What is the capital of France?", new string[] { "Berlin", "Madrid", "Paris", "Rome" }, 2));
            quiz.AddQuestion(new Question("What is 2 + 2?", new string[] { "3", "4", "5", "6" }, 1));
            quiz.AddQuestion(new Question("Which planet has life?", new string[] { "Earth", "Jupiter", "Saturn", "Mars" }, 0));

            quiz.TakeQuiz();

            quiz.DisplayResults();
        }
    }
}

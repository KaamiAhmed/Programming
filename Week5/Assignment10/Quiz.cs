
namespace Assignment10
{
    internal class Quiz
    {
        public Question[] Questions;
        public int QuestionCount;
        public int Score;


        public Quiz(int numberOfQuestions)
        {
            Questions = new Question[numberOfQuestions];
            QuestionCount = 0;
            Score = 0;
        }

        public void AddQuestion(Question question)
        {
            if (QuestionCount < Questions.Length)
            {
                Questions[QuestionCount] = question;
                QuestionCount++;
            }
            else
            {
                Console.WriteLine("Quiz is full.");
            }
        }

        public void TakeQuiz()
        {
            for (int i = 0; i < QuestionCount; i++)
            {
                Console.WriteLine($"Question {i + 1}: {Questions[i].QuestionText}");

                for (int j = 0; j < Questions[i].Options.Length; j++)
                {
                    Console.WriteLine($"{j + 1}. {Questions[i].Options[j]}");
                }

                Console.Write($"Enter your answer: (1-4): ");
                int userAnswer = int.Parse(Console.ReadLine()) - 1;

                if(userAnswer == Questions[i].CorrectAnswerIndex)
                {
                    Score++;
                }
            }
            
        }

        public void DisplayResults()
        {
            Console.WriteLine($"Your score: {Score}/{QuestionCount}");
        }
    }
}
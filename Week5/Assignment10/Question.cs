
namespace Assignment10
{
    internal class Question
    {
        public string QuestionText;
        public string[] Options;
        public int CorrectAnswerIndex;

        public Question(string questionText, string[] options, int correctAnswerIndex)
        {
            QuestionText = questionText;
            Options = options;
            CorrectAnswerIndex = correctAnswerIndex;
        }
    }
}

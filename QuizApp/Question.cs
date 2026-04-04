namespace QuizApp
{
    internal class Question(string questionText, string[] answers, int correctAnswerIndex)
    {
        public string? QuestionText { get; set; } = questionText;

        // ? after the brackets mean that the array can be null.
        public string[]? Answers { get; set; } = answers;
        public int CorrectAnswerIndex { get; set; } = correctAnswerIndex;

        public bool IsCorrect(int userChoice)
        {
            if (CorrectAnswerIndex == userChoice)
            {
                Quiz.Score += 1;
                return true;
            }
            return false;
        }
    }
}

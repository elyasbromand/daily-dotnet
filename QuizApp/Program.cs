namespace QuizApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Question[] questions =
            [
                new("What is the capital of Afghanistan?", ["Kabul", "Tehran", "Islamabad"], 0),
                new("What is the capital of France?", ["Berlin", "Madrid", "Paris"], 2),
            ];

            Quiz quiz = new(questions);

            Quiz.DisplayQuestion(questions[0]);
        }
    }
}

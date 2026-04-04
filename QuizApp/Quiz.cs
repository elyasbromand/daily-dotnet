namespace QuizApp
{
    internal class Quiz(Question[] questions)
    {
        private readonly Question[] _questions = questions;

        public static void DisplayQuestion(Question question)
        {
            Console.WriteLine(question.QuestionText);
            //Display the givin answers
            for (int i = 0; i < question.Answers!.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"{i + 1}. {question.Answers[i]}");
                Console.ResetColor();
            }
        }

        private static int GetUserInput()
        {
            Console.Write("Your answer: ");

            string? input = Console.ReadLine();

            int userChoice;

            while (!int.TryParse(input, out userChoice) || userChoice < 1 || userChoice > 3)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");

                input = Console.ReadLine();
            }

            return userChoice - 1;
        }

        public void StartQuiz()
        {
            foreach (Question question in _questions)
            {
                DisplayQuestion(question);
                int userChoice = GetUserInput();

                if (question.IsCorrect(userChoice))
                    Console.WriteLine("Correct!");
                else
                    Console.WriteLine(
                        $"Incorrect! The correct answer is {question.Answers![question.CorrectAnswerIndex]}"
                    );
                Console.WriteLine();
            }
        }
    }
}

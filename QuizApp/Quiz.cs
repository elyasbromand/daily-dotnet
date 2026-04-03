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

            if (question.IsCorrect(GetUserInput()))
            {
                Console.WriteLine("Correct!");
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

            Console.WriteLine(userChoice - 1);

            return userChoice - 1;
        }
    }
}

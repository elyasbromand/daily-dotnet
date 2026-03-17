namespace calculator1
{
    public class Exercise
    {
        public void SimpleCalculator()
        {
            // TODO: Implement the calculator logic here

            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Choose an operation: +, -, *, /");
            char op = char.Parse(Console.ReadLine()!);

            if (op == '/' && num2 == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            else
            {
                string result = op switch
                {
                    '+' => "Result: " + Convert.ToString(num1 + num2),
                    '-' => "Result: " + Convert.ToString(num1 - num2),
                    '/' => "Result: " + Convert.ToString(num1 / num2),
                    '*' => "Result: " + Convert.ToString(num1 * num2),
                    _ => "Invalid operation. Please choose +, -, *, or /.",
                };
                Console.WriteLine(result);
            }
        }
    }
}

while (true)
{
    string userInput = Console.ReadLine()!;

    // you can create a variable to store the parsed result.
    bool isParsed = int.TryParse(userInput, out int result);

    if (isParsed)
    {
        Console.WriteLine(result);
        break;
    }
    else
        Console.WriteLine("Invalid input, please enter a valid integer.");
}

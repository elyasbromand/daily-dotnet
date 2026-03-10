string? userInput = Console.ReadLine();

Write(userInput);

//<summary>
//this method writes the input to the console
//</summary>
static void Write(string? input)
{
    Console.WriteLine(input);
}

#pragma warning disable CS0168
int unusedVar;
#pragma warning restore CS0168

System.Console.WriteLine();

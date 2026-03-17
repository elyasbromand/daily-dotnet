Console.Write("Progress: 0%");
for (int i = 1; i <= 100; i++)
{
    // Simulate work
    Thread.Sleep(50);
    // Overwrites the previous output on the same line
    Console.Write($"\rProgress: {i}%");
}
Console.WriteLine("\nCompleted!");

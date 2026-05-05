namespace Logging;

public class Program
{
    public static void Main(string[] args)
    {
        File.AppendAllText("log.txt", $"Log entry at {DateTime.Now} \n");
        Console.WriteLine("Log entry written to log.txt");
    }
}
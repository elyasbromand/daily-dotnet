namespace WeatherSimulator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Using2DArray.Run();

            System.Console.WriteLine("Enter the number of days to simulate:");
            int days = int.Parse(Console.ReadLine()!);

            // old syntax but working and necessary for array declaration
            int[] temperatures = new int[days];
            // new syntax when you know the values beforehand - this is called compression syntax
            string[] conditions = ["sunny", "cloudy", "rainy", "snowy"];

            string[] weatherConditions = new string[days];

            Random random = new();
            // temperature and weather condition generation logic
            for (int i = 0; i < days; i++)
            {
                temperatures[i] = random.Next(-10, 41);
                if (temperatures[i] < 10)
                {
                    weatherConditions[i] = conditions[random.Next(2, 4)];
                    continue;
                }
                weatherConditions[i] = conditions[random.Next(0, 2)];
            }
            for (int i = 0; i < days; i++)
            {
                System.Console.WriteLine(
                    $"Day {i + 1} - Temperature: {temperatures[i]}°C, Condition: {weatherConditions[i]}"
                );
            }
        }
    }
}

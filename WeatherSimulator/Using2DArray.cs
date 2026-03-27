namespace WeatherSimulator
{
    public class Using2DArray
    {
        public static void Run()
        {
            System.Console.WriteLine("2D - Enter the number of days to simulate:");
            int days = int.Parse(Console.ReadLine()!);
            // the first column will be temperature and second will be weather condition
            string[,] weatherData = new string[days, 2];

            Random random = new();

            string[] conditions = ["sunny", "cloudy", "rainy", "snowy"];

            for (int i = 0; i < days; i++)
            {
                weatherData[i, 0] = Convert.ToString(random.Next(-10, 41));
                if (Convert.ToInt16(weatherData[i, 0]) < 10)
                {
                    weatherData[i, 1] = conditions[random.Next(2, 4)];
                    continue;
                }
                weatherData[i, 1] = conditions[random.Next(0, 2)];
            }

            for (int i = 0; i < days; i++)
            {
                Console.WriteLine(
                    $"Day {i + 1} - Temperature: {weatherData[i, 0]}°C, Condition: {weatherData[i, 1]}"
                );
            }
        }
    }
}

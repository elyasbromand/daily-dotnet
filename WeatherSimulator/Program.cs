namespace WeatherSimulator
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Using2DArray.Run();

            System.Console.WriteLine("Enter the number of days to simulate:");
            int days = int.Parse(Console.ReadLine()!);

            // old syntax but working and necessary for array declaration
            int[] temperatures = new int[days];
            // new syntax when you know the values beforehand - this is called compression syntax
            string[,] conditions =
            {
                { "sunny", "0" },
                { "cloudy", "0" },
                { "rainy", "0" },
                { "snowy", "0" },
            };

            string[] weatherConditions = new string[days];

            Random random = new();

            // temperature and weather condition generation logic
            for (int i = 0; i < days; i++)
            {
                temperatures[i] = random.Next(-10, 41);
                if (temperatures[i] < 10)
                {
                    weatherConditions[i] = conditions[random.Next(2, 4), 0];
                    continue;
                }
                weatherConditions[i] = conditions[random.Next(0, 2), 0];
            }

            // Print Weather conditions and temperature
            for (int i = 0; i < days; i++)
            {
                System.Console.WriteLine(
                    $"Day {i + 1} - Temperature: {temperatures[i]}°C, Condition: {weatherConditions[i]}"
                );
            }

            // Cound the occurrances of each Condition
            for (int i = 0; i < weatherConditions.Length; i++)
            {
                switch (weatherConditions[i])
                {
                    case "sunny":
                        {
                            conditions[0, 1] = Convert.ToString(
                                Convert.ToInt16(conditions[0, 1]) + 1
                            );
                        }

                        break;
                    case "cloudy":
                        {
                            conditions[1, 1] = Convert.ToString(
                                Convert.ToInt16(conditions[1, 1]) + 1
                            );
                        }
                        break;
                    case "rainy":
                        {
                            conditions[2, 1] = Convert.ToString(
                                Convert.ToInt16(conditions[2, 1]) + 1
                            );
                        }
                        break;
                    case "snowy":
                        {
                            conditions[3, 1] = Convert.ToString(
                                Convert.ToInt16(conditions[3, 1]) + 1
                            );
                        }
                        break;
                }
            }

            //Display the occurrances of each condition
            for (int i = 0; i < conditions.GetLength(0); i++)
            {
                Console.WriteLine($"{conditions[i, 0]} is occured {conditions[i, 1]} times");
            }
        }
    }
}

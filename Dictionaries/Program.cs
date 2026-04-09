using System.Data;

namespace Dictionaries
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var codes = new Dictionary<string, string>
            { //Key should be inclosed with square brackates
                ["AFG"] = "Afghanistan",
                ["NY"] = "New York City",
            };

            // Getting Value gracefully
            if (codes.TryGetValue("AFG", out string? state))
            {
                Console.Write(state);
            }

            Console.WriteLine(state);
        }
    }
}

using System.Data;

namespace Dictionaries
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string[]> employees = [];

            employees.Add(100, ["Ahmad", "Doctor"]);
            employees.Add(101, ["Ali", "Engineer"]);

            // in the type of employee in foreach loop you can use var
            // but to actually know what is happening I will add the type
            // Each element in the Dictionary is KeyValuePair of the same type, so you need to keep that in mind.
            // You can't use Dictionary<int, string[]> as type of each element since each element is not a dictionary, it is a pair

            foreach (KeyValuePair<int, string[]> employee in employees)
            {
                Console.WriteLine(employee.Value[0]);
            }
        }
    }
}

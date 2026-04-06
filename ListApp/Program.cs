namespace ListApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // old way
            List<string> names = new List<string>() { "John", "Jane", "Doe", "john" };
            // new way
            List<string> strings = ["asdf", "fdsa", "qwerty", "ytrewq"];

            // showing list in names format:
            Console.WriteLine("Names: " + string.Join(", ", names));

            names.Add("Adam smith");

            names.RemoveAll(name => name.Equals("John", StringComparison.OrdinalIgnoreCase));

            // let's use predicate to check names which has length greater than 4

            Predicate<string> hasLengthGreaterThan4 = name => name.Length > 5;

            List<string> longNames = names.FindAll(hasLengthGreaterThan4);

            foreach (string name in longNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}

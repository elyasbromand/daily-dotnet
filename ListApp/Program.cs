namespace ListApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // old way
            List<string> names = new List<string>() { "John", "Jane", "Doe" };
            // new way
            List<string> strings = ["asdf", "fdsa", "qwerty", "ytrewq"];

            // showing list in names format:
            Console.WriteLine("Names: " + string.Join(", ", names));

            names.Add("Adam smith");
        }
    }
}
    
namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new("BMW");
            Car benz = new("Benz");

            Console.WriteLine(bmw.Model);

            bmw.Model = "asdf";
        }
    }
}
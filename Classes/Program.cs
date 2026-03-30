namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new("BMW", isElectric: true);
            Car benz = new("Benz", isElectric: true);

            Console.WriteLine(benz.Model);
            Console.WriteLine(benz.IsElectric);

            bmw.Model = "asdf";
        }
    }
}

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // OperatorOverloading point1 = new(12, 13);
            // OperatorOverloading point2 = new(2, 15);

            // OperatorOverloading point3 = point1 + point2;

            // Console.Write($"Point3 is at ({point3.Xaxis}, {point3.Yaxis})");

            // calling non-static method within it's own class without creating an object of it.

            new Customers().DisplayME();
        }
    }
}

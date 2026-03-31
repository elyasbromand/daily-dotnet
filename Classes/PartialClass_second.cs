namespace Classes
{
    internal partial class PartialClass
    {
        // second property is int
        public int? PartialProperty2 { get; set; } = partialProperty2;

        public void DisplayPartialProperties()
        {
            Console.WriteLine($"Partial Property 1: {PartialProperty1}");
            Console.WriteLine($"Partial Property 2: {PartialProperty2}");
        }

        public static partial string PrintWorld() => "Hello from Partial Method World";
    }
}

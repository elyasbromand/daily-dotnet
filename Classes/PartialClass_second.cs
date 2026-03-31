namespace Classes
{
    internal partial class PartialClass
    {
        // second property is int
        public int? PartialProperty2 { get; set; }

        public void DisplayPartialProperties()
        {
            Console.WriteLine($"Partial Property 1: {PartialProperty1}");
            Console.WriteLine($"Partial Property 2: {PartialProperty2}");
        }
    }
}

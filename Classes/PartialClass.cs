using System.ComponentModel;

namespace Classes
{
    internal partial class PartialClass(string? partialProperty1, int? partialProperty2)
    {
        public static partial string PrintWorld();

        public string? PartialProperty1 { get; set; } = partialProperty1;
    }
}

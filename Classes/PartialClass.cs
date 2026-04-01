using System.ComponentModel;

namespace Classes
{
    internal partial class PartialClass(string? partialProperty1, int? partialProperty2)
    {
        public static partial string PrintWorld();

        public string? PartialProperty1 { get; set; } = partialProperty1;
    }
}


// Note that if a partial function has a return type, then you should give it an access modifer and it also should be implemented.

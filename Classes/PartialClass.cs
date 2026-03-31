namespace Classes
{
    internal partial class PartialClass
    {
        // the second int property is in another file which is partial class of this class, so we can access it in constructor.
        public PartialClass(string? partialProperty1, int? partialProperty2)
        {
            PartialProperty1 = partialProperty1;
            PartialProperty2 = partialProperty2;
        }

        public string? PartialProperty1 { get; set; }
    }
}

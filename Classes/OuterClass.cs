namespace Classes
{
    public class OuterClass(string? outerProperty)
    {
        // This is outer class property which is not accessible to inner class directly, we need to create give the reference of it to inner class to access it.
        public string? OuterProperty { get; set; } = outerProperty;

        public class InnerClass
        {
            // This is inner class constructor which takes the reference of outer class as parameter to access the outer class property.
            public InnerClass(OuterClass outer)
            {
                Outer = outer;
            }

            // This is Default constructor which doesn't take reference of outer class, instead it will be a normal constructor.
            // public InnerClass()
            // {
            //     InnerProperty = "Default Inner Property";
            // }

            public OuterClass? Outer { get; set; }

            public string? InnerProperty { get; set; }
            public string? InnerProperty2 { get; set; }

            public void DisplayInnerProperty()
            {
                Console.WriteLine($"Inner Property: {InnerProperty}");
                Console.WriteLine($"Inner Property 2: {InnerProperty2}");
            }
        }

        protected void DisplayOuterProperty()
        {
            Console.WriteLine($"Outer Property: {OuterProperty}");
        }
    }
}

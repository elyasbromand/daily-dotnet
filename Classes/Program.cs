namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating outer instance
            OuterClass outer = new("Hello Outer");
            // creating inner instance and passing the reference of outer instance to it's constructor and also initializing the inner properties using object initializer syntax.
            OuterClass.InnerClass inner = new(outer)
            {
                InnerProperty = "Hello Inner",
                InnerProperty2 = "Hello Inner 2",
            };

            inner.DisplayInnerProperty(); // prints Inner Property
            // accessing outer property from inner class
            Console.WriteLine(inner.Outer?.OuterProperty);
        }
    }
}

namespace Classes
{
    internal class Car(String model = "unknown")
    {
        // This is Auto implemented property, it will automatically create a private field to store the value of the property
        public string Model { get; set; } = model;
    }
}

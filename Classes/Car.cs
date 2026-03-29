namespace Classes
{
    internal class Car(String model = "unknown")
    {
        // This is Auto implemented property, it will automatically create a private field to store the value of the property. and at first it will take the constructor parameter and assign it to the property. 
        // public string Model { get; set; } = model;

        // You can also do it manually by creating a private field and a public property to access it
        private string _model = model;
        public string Model
        {
            get => _model;
            set => _model = value;
        }
    }
}

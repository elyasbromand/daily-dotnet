namespace Classes
{
    internal class Car(string model = "unknown", bool isElectric = false)
    {
        // This is Auto implemented property, it will automatically create a private field to store the value of the property. and at first it will take the constructor parameter and assign it to the property.
        // public string Model { get; set; } = model;

        // You can also do it manually by creating a private field and a public property to access it
        private string _model = model;
        private bool _isElectric = isElectric;
        public string Model
        {
            get
            {
                if (_isElectric)
                    return _model + " (Electric)";
                else
                    return _model + " (Gasoline)";
            }
            set
            {
                if (value == "Benz")
                {
                    _model = value + "asdf";
                }
                else
                {
                    _model = value;
                }
            }
        }

        public bool IsElectric
        {
            get => _isElectric;
            set => _isElectric = value;
        }
    }
}

// in the example code above the primary constructore will set the model to whatever is passed, it won't trigger the setter method in property, so if you we want to trigger setter method we can do it manually by creating another constructor that will pass the value to the property. Will be mentioned in next version. 

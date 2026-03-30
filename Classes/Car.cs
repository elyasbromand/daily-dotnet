namespace Classes
{
    internal class Car
    {
        public Car(string model = "unknown", bool isElectric = false)
        {
            Model = model;
            IsElectric = isElectric;
        }

        private string? _model;
        private bool _isElectric;
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
                    _model = value + " asdf";
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

// Here is how you use the setter in the construction phase.

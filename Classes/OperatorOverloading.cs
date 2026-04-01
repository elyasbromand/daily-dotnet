namespace Classes
{
    internal class OperatorOverloading
    {
        public int Xaxis { get; set; }
        public int Yaxis { get; set; }

        public OperatorOverloading(int x, int y)
        {
            Xaxis = x;
            Yaxis = y;
        }

        public static OperatorOverloading operator +(OperatorOverloading a, OperatorOverloading b)
        {
            // returning a new object.
            return new OperatorOverloading(a.Xaxis + b.Xaxis, a.Yaxis + b.Yaxis);
        }
    }
}

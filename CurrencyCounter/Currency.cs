namespace CurrencyCounter
{
    public class Currency
    {
        public Currency(double value, string name)
        {
            Value = value;
            Name = name;
        }
        public string Name { get; set; }

        public double Value { get; set; }
    }
}

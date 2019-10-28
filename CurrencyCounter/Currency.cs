using System.Collections.Generic;

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

        public static List<Currency> exchange = new List<Currency>
        {
            new Currency(1, "USD"),
            new Currency(0.90, "EUR"),
            new Currency(63.97, "RUB"),
            new Currency(0.78, "GBP"),
            new Currency(0.99, "CHF"),
            new Currency(3.85, "PLN"),
            new Currency(108.54, "JPY"),
            new Currency(24.75, "UAH"),
            new Currency(1.31, "CAD"),
            new Currency(1.46, "AUD"),
            new Currency(2.97, "GEL"),
            new Currency(17.40, "MDL"),
            new Currency(7.09, "CNY"),
            new Currency(6.72, "DKK"),
            new Currency(9.18, "NOK"),
            new Currency(9.71, "SEK"),
            new Currency(2.04, "BYR"),
            new Currency(23.06, "CZK"),
            new Currency(124.55, "ISK"),
            new Currency(9.67, "SKK"),
            new Currency(3.54, "ILS"),
            new Currency(389.70, "KZT"),
            new Currency(297.83, "HUF"),
            new Currency(0.61, "LVL"),
            new Currency(2.95, "LTL"),
            new Currency(1.37, "SGD")
        };
    }
}

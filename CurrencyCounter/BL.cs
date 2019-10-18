using System;
using System.Collections.Generic;
using System.Linq;

namespace CurrencyCounter
{
    public class BL
    {
        public static Dictionary<double, string> exchange;

        public BL()
        {
            exchange = new Dictionary<double, string>
            {
                {1, "USD"},
                {0.90, "EUR"},
                {63.97, "RUB"},
                {0.78, "GBP"},
                {0.99, "CHF"},
                {3.85, "PLN"},
                {108.54, "JPY"},
                {24.75, "UAH"},
                {1.31, "CAD"},
                {1.46, "AUD"},
                {2.97, "GEL"},
                {17.40, "MDL"},
                {7.09, "CNY"},
                {6.72, "DKK"},
                {9.18, "NOK"},
                {9.71, "SEK"},
                {2.04, "BYR"},
                {23.06, "CZK"},
                {124.55, "ISK"},
                {9.67, "SKK"},
                {3.54, "ILS"},
                {389.70, "KZT"},
                {297.83, "HUF"},
                {0.61, "LVL"},
                {2.95, "LTL"},
                {1.37, "SGD"}
            };
        }

        public Bill ToDollar(Bill bill, string currency)
        {
            var current = (double) (bill.Greenbacks + (0.01 * (double) bill.Coins));
            var rate = exchange.FirstOrDefault(x => x.Value == currency).Key;
            current = current / rate;
            current = Math.Round(current, 2);
            string[] parts = current.ToString().Split('.');
            return new Bill(int.Parse(parts[0]), int.Parse(parts[1]));
        }

        public Bill FromDollar(Bill bill, string currency)
        {
            var current = (double) (bill.Greenbacks + (0.1 * (double) bill.Coins));
            var rate = exchange.FirstOrDefault(x => x.Value == currency).Key;
            current = current * rate;
            string[] parts = current.ToString().Split('.');
            return new Bill(int.Parse(parts[0]), int.Parse(parts[1]));
        }
    }
}

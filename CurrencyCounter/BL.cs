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
            if (bill.Coins == 0)
            {
                bill.Coins = 0.0001;
            }

            var current = (bill.Greenbacks + bill.Coins);
            var rate = exchange.FirstOrDefault(x => x.Value == currency).Key;
            current = Math.Round((current / rate), 2);
            if (current % 1 == 0)
            {
                return new Bill(current, 0.0);
            }
            else
            {
                string[] parts = current.ToString().Split('.');
                var coins = Math.Round(double.Parse("0." + parts[1]), 2);
                return new Bill(int.Parse(parts[0]), coins);
            }
        }

        public Bill FromDollar(Bill bill, string currency)
        {
            if (bill.Coins == 0)
            {
                bill.Coins = 0.0001;
            }
            var current = (bill.Greenbacks + bill.Coins);
            var rate = exchange.FirstOrDefault(x => x.Value == currency).Key;
            current = Math.Round((current * rate), 2);
            if (current % 1 == 0)
            {
                return new Bill(current, 0.0);
            }
            else
            {
                string[] parts = current.ToString().Split('.');
                var coins = Math.Round(double.Parse("0." + parts[1]), 2);
                return new Bill(int.Parse(parts[0]), coins);
            }
        }
    }
}

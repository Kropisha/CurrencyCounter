using System;
using System.Linq;

namespace CurrencyCounter
{
    public class Bill
    {
        public double Greenbacks { get; set; }

        public double Coins { get; set; }

        public Bill(double cash, double coins)
        {
            Greenbacks = cash;
            Coins = coins;
        }

        public static Bill operator +(Bill one, Bill two)
        {
            double current = (one.Greenbacks + one.Coins) + (two.Greenbacks + two.Coins);
            var whole = (int) Math.Truncate(current);
            return new Bill(whole,current - whole );
        }

        public static Bill operator -(Bill one, Bill two)
        {
            double current = (one.Greenbacks + one.Coins) - (two.Greenbacks + two.Coins);
            var whole = (int)Math.Truncate(current);
            return new Bill(whole, current - whole);
        }

        public override string ToString()
        {
            return $"The result is : {Greenbacks + Math.Round(Coins, 2)}";
        }

        public Bill ToDollar(Bill bill, string currency)
        {
            if (bill.Coins == 0)
            {
                bill.Coins = 0.0001;
            }

            var current = (bill.Greenbacks + bill.Coins);
            var rate = Currency.exchange.FirstOrDefault(x => x.Name == currency).Value;
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
            var rate = Currency.exchange.FirstOrDefault(x => x.Name == currency).Value;
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

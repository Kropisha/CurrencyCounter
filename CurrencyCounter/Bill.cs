using System;

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
    }
}

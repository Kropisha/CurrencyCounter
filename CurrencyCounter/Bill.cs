using System;

namespace CurrencyCounter
{
    public class Bill
    {
        public int Greenbacks { get; set; }

        public decimal Coins { get; set; }

        public Bill(int cash, decimal coins)
        {
            Greenbacks = cash;
            Coins = coins;
        }

        public static Bill operator +(Bill one, Bill two)
        {
            decimal current = (one.Greenbacks + one.Coins) + (two.Greenbacks + two.Coins);
            var whole = (int) Math.Truncate(current);
            return new Bill(whole,current - whole );
        }

        public static Bill operator -(Bill one, Bill two)
        {
            decimal current = (one.Greenbacks + one.Coins) - (two.Greenbacks + two.Coins);
            var whole = (int)Math.Truncate(current);
            return new Bill(whole, current - whole);
        }

        public override string ToString()
        {
            return $"The result is : {Greenbacks},{Coins}";
        }
    }
}

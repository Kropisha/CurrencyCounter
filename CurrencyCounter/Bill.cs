using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

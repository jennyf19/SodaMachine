//Ferries, Jenny
//Soda Machine Exercise 04

using System;

namespace SodaMachine
{
    class Coin
    {
        //notes from class 1/23
        private Denomination coinObject;

        public enum Denomination
        { SLUG = 0, NICKEL = 5, DIME = 10, QUARTER = 25, HALFDOLLAR = 50 }
        public Coin()
        {
            coinObject = Denomination.SLUG;
        }

        public Coin(Denomination coinEunmeral)
        {
            coinObject = coinEunmeral;
        }

        public Coin(string coinName)
        {
            Denomination coinEnumeral;
            if (Enum.IsDefined(typeof(Denomination), coinName) &&
                Enum.TryParse<Denomination>(coinName, out coinEnumeral))
            {
                coinObject = coinEnumeral;
            }
            else
            {
                coinObject = Coin.Denomination.SLUG;
            }
        }

        public Coin(decimal coinValue)
        {
            Denomination value = (Denomination)(coinValue * 100);
            switch (value)
            {
                case Denomination.NICKEL:
                case Denomination.DIME:
                case Denomination.QUARTER:
                case Denomination.HALFDOLLAR:
                    coinObject = value;
                    break;
                default:
                    coinObject = Denomination.SLUG;
                    break;
            }
        }

        public decimal ValueOfCoin
        {
            get
            {
                return (decimal)coinObject * .01M;
            }
        }

        public Denomination CoinEnumeral
        {
            get
            {
                return coinObject;
            }
        }
    }
}

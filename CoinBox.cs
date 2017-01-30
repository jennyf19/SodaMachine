//Ferries, Jenny
//Soda Machine Exercise 05

using System;
using System.Collections.Generic;
using System.Linq;

namespace SodaMachine
{
    class CoinBox
    {
        private List<Coin> box;

        // constructor to create an empty coin box 
        public CoinBox()
        {
            box = new List<Coin>();
        }
        // constructor to create a coin box with some coins in it 
        public CoinBox(List<Coin> SeedMoney)
        {
            box = SeedMoney;
        }

        // put a coin in the coin box 
        public void Deposit(Coin ACoin)
        {
            box.Add(ACoin);
        }

        // take a coin of the specified denomination out of the box 
        public Boolean Withdraw(Coin.Denomination ACoinDenomination)
        {
            var aCoin =
                from firstCoin in box
                where firstCoin.CoinEnumeral == ACoinDenomination
                select firstCoin;

            Boolean result = false;
            if (aCoin.Count() > 0)
            {
                result = box.Remove(aCoin.First());
            }
            return result;
        }

        // number of half dollars in the coin box 
        public int HalfDollarCount
        {
            get
            {
                var halfDollar =
                    from coin in box
                    where coin.CoinEnumeral == Coin.Denomination.HALFDOLLAR
                    select coin;
                return halfDollar.Count();
            }
        }

        // number of quarters in the coin box 
        public int QuarterCount
        {
            get
            {
                var quarter =
                    from coin in box
                    where coin.CoinEnumeral == Coin.Denomination.QUARTER
                    select coin;

                return quarter.Count();
            }
        }

        // number of dimes in the coin box 
        public int DimeCount
        {
            get
            {
                var dime =
                    from coin in box
                    where coin.CoinEnumeral == Coin.Denomination.DIME
                    select coin;

                return dime.Count();
            }
        }

        // number of nickels in the coin box 
        public int NickelCount
        {
            get
            {
                var nickel =
                    from coin in box
                    where coin.CoinEnumeral == Coin.Denomination.NICKEL
                    select coin;

                return nickel.Count();
            }
        }

        // number of worthless coins in the coin box 
        public int SlugCount
        {
            get
            {
                var slug =
                    from coin in box
                    where coin.CoinEnumeral == Coin.Denomination.SLUG
                    select coin;

                return slug.Count();
            }
        }


        // total amount of money in the coin box 
        public decimal ValueOf
        {
            get
            {
                decimal result =
                    HalfDollarCount * (decimal)Coin.Denomination.HALFDOLLAR * .01M +
                    QuarterCount * (decimal)Coin.Denomination.QUARTER * .01M +
                    DimeCount * (decimal)Coin.Denomination.DIME * .01M +
                    NickelCount * (decimal)Coin.Denomination.NICKEL * .01M;
                return result;

            }
        }
    }
}

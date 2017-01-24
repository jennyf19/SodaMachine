//Ferries, Jenny
//Soda Machine Exercise 02

using System;

namespace SodaMachine
{

    //  This class represents the purchase price of something. //  In our software project, we will use it to represent the price of //  one can of soda. class PurchasePrice 
    class PurchasePrice
    {
        private decimal price = 0M;
        public PurchasePrice()
        {
            price = 0M;
        }

        //attribute 
        [Obsolete("Use decimal version", false)]
        public PurchasePrice(int initialPrice)
        {
            price = ((decimal)initialPrice) / 100M;
        }

        public PurchasePrice(decimal initialPrice)
        {
            PriceDecimal = initialPrice;
        }

        private decimal _price;

        [Obsolete("Use decimal version", false)]
        public int Price
        {
            get
            {
                return (int)(_price * 100);
            }
            set
            {
                _price = (decimal)(value * .01M);
            }
        }

        public decimal PriceDecimal
        {
            get
            {
                return price;
            }
            set
            {
                _price = value;
            }
        }
    }
}


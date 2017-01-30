//Ferries, Jenny
//Soda Machine Exercise 05

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
            price = initialPrice;
        }

        public PurchasePrice(decimal initialPrice)
        {
            PriceDecimal = initialPrice;
        }

        [Obsolete("Use decimal version", false)]
        public int Price
        {
            get
            {
                return (int)(price * 100);
            }
            set
            {
                price = (decimal)(value * .01M);
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
                price = value;
            }
        }
    }
}


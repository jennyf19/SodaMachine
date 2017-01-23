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

        [Obsolete("Use deicmal version", false)]
        public PurchasePrice(int initialPrice)
        {
            price = ((decimal)initialPrice) / 100M;
        }

        public PurchasePrice(decimal initialPrice)
        {
            price = initialPrice;
        }
        public decimal Price
        {
            get
            {
                return (int)(price*100);
            }
        }
        public decimal PriceDecimal
        {
            get
            {
                return price;
            }
        }
    }
}


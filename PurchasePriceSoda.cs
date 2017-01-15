using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{

    //  This class represents the purchase price of something. //  In our software project, we will use it to represent the price of //  one can of soda. class PurchasePrice 
    class PurchasePriceSoda
    {
        private decimal price = 0;
        public PurchasePriceSoda()
        {
            price = 0;
        }

        public PurchasePriceSoda(decimal initialPrice)
        {
            this.price = initialPrice;
        }

        public decimal Price
        {
            get
            {
                return price;
            }
        }
        public void DespenseSoda(decimal price)
        {
            Console.Write("Soda costs $ " + price + "\nEnter an amount of money:\n$");

            //variable of type decimal to store user input
            decimal userNum;

            //TryParse method to convert input to decimal
            decimal.TryParse(Console.ReadLine(), out userNum);

            //Check that the user entered a number >= 0
            if (userNum >= price)
            {
                //Determine the total number of sodas purchased
                int totalSoda = (int)(userNum / price);

                //Determine the user's change after purchasing the soda
                decimal change = userNum - (totalSoda * price);

                Console.WriteLine("\nYou inserted $" + userNum + ".\nYou have purchased " + totalSoda + " sodas." +
                "You have $" + change + " in change.");
            }
            else
            {
                Console.WriteLine("You don't have enough money to purchase soda.");
            }

        }
    }
}

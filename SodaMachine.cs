//Ferries, Jenny
//Soda Machine Exercise 01

using System;

namespace SodaMachine
{
    class SodaMachine : IVendingMachine
    {
        public void DespenseSoda()
        {
            Console.Write("Soda costs $0.35. Enter an amount of money:\n$");

            //variable of type decimal to store user input
            decimal userNum;

            //TryParse method to convert input to decimal
            decimal.TryParse(Console.ReadLine(), out userNum);

            //Check that the user entered a number >= 0
            if (userNum >= 0)
            {
                //Determine the total number of sodas purchased
                int totalSoda = (int)(userNum / .35m);

                //Determine the user's change after purchasing the soda
                decimal change = userNum - (totalSoda * .35m);

                Console.WriteLine("\nYou inserted $" + userNum + ".\nYou have purchased " + totalSoda + " sodas." +
                "You have $" + change + " in change.");
            }
            else
            {
                Console.WriteLine("You need to enter a positive amount of money.");
            }
        }
    }
}

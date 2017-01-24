//Ferries, Jenny
//Soda Machine Exercise 02

using System;

namespace SodaMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            PurchasePrice sodaPrice = new PurchasePrice(0.35M);
            CanRack sodaRack = new CanRack();

            while (true)
            {
                Console.WriteLine("Hello. Welcome to the Visual Studio Soda Machine\n"
                    + "Would you like to continue? Enter y or n: ");

                string userInput = Console.ReadLine();

                if (userInput.Equals("y") || userInput.Equals("Y"))
                {
                    Console.WriteLine("Please insert your money {0:c}", sodaPrice.PriceDecimal);
                    decimal valueInserted = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("You inserted {0:c}", valueInserted);

                    Console.WriteLine("There are three racks of soda(regular, diet, fanta), which one would you like?");
                    string userChoice = Console.ReadLine();

                    if (userChoice == "regular")
                    {
                        sodaRack.RemoveACanOf(Flavor.regular);
                    }
                    else if (userChoice == "diet")
                    {
                        sodaRack.RemoveACanOf(Flavor.diet);
                    }
                    else if (userChoice == "fanta")
                    {
                        sodaRack.RemoveACanOf(Flavor.fanta);
                    }
                    else
                    {
                        Console.WriteLine("Enter a type of soda (regular, diet, fanta)");
                    }
                    Console.WriteLine("Thanks for coming. Here is your can of {0} soda", userChoice);
                }
                else
                {
                    Console.WriteLine("Sounds like you don't want to purchase a virtual soda\n" +
                        "Have a nice day. Come again");
                }

                Console.ReadLine();
            }
        }
    }
}

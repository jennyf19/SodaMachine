//Ferries, Jenny
//Soda Machine Exercise 04

using System;
using System.Collections.Generic;

namespace SodaMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            PurchasePrice sodaPrice = new PurchasePrice(0.35M);
            CanRack sodaRack = new CanRack();
            CoinBox insertedCoin = new CoinBox(new List<Coin>
            {
                new Coin(Coin.Denomination.QUARTER), new Coin(Coin.Denomination.DIME),
                new Coin(Coin.Denomination.NICKEL)
            });

            while (true)
            {
                Console.WriteLine("Hello. Welcome to the Visual Studio Soda Machine\n"
                    + "Would you like to continue? Enter y or n: ");

                string userInput = Console.ReadLine();

                if (userInput.Equals("y") || userInput.Equals("Y"))
                {
                    Console.WriteLine("Can Rack contents: ");

                    sodaRack.DisplayCanRack();

                    Console.WriteLine("Please insert your money {0:c}", sodaPrice.PriceDecimal);

                    decimal valueInserted = 0M;

                    while (valueInserted < sodaPrice.PriceDecimal)
                    {
                        string coinNameInserted = Console.ReadLine().ToUpper();
                        Coin coinInserted = new Coin(coinNameInserted);

                        Console.WriteLine("You inserted {0:c}", coinInserted);

                        insertedCoin.Deposit(coinInserted);

                        valueInserted += coinInserted.ValueOfCoin;

                        Console.WriteLine("You have inserted {0:c}", valueInserted);
                    }

                    Boolean canDispense = false;
                    while (!canDispense)
                    {
                        Console.WriteLine("There are three racks of soda(regular, diet, fanta), which one would you like?");
                        string userChoice = Console.ReadLine();

                        if (userChoice == "regular")
                        {
                            sodaRack.RemoveACanOf(Flavor.regular);
                            canDispense = true;
                        }
                        else if (userChoice == "diet")
                        {
                            sodaRack.RemoveACanOf(Flavor.diet);
                            canDispense = true;
                        }
                        else if (userChoice == "fanta")
                        {
                            sodaRack.RemoveACanOf(Flavor.fanta);
                            canDispense = true;
                        }
                        else
                        {
                            Console.WriteLine("Enter a type of soda (regular, diet, fanta)");
                        }
                        Console.WriteLine("Thanks for coming. Here is your can of {0} soda", userChoice);
                        Console.WriteLine("Contents of Coin Box:");

                        Console.WriteLine("{0}\tHalf Dollar(s)", insertedCoin.HalfDollarCount);
                        Console.WriteLine("{0}\tQuarter(s)", insertedCoin.QuarterCount);
                        Console.WriteLine("{0}\tDime(s)", insertedCoin.DimeCount);
                        Console.WriteLine("{0}\tNickel(s)", insertedCoin.NickelCount);
                        Console.WriteLine("{0}\tSlug(s)", insertedCoin.SlugCount);
                        Console.WriteLine("Total value in coin box is {0:c}", insertedCoin.ValueOf);
                    }
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

using System;
using System.Collections.Generic;
using System.Linq;
//Ferries, Jenny
//Soda Machine Exercise 01

namespace SodaMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hello. Welcome to the Visual Studio Soda Machine\n"
                    + "Would you like to continue? Enter y or n: ");

                string userInput = Console.ReadLine();

                if (userInput.Equals("y") || userInput.Equals("Y"))
                {
                    CanRack newRack = new CanRack();
                    Console.WriteLine("There are three racks of soda(regular, diet, fanta), which one would you like?");
                    string userChoice = Console.ReadLine();
                    
                    if(userChoice == "regular")
                    {
                        newRack.IsFull("regular");
                        Console.WriteLine("How much does one can of soda cost?");

                        decimal sodaCost;
                        decimal.TryParse(Console.ReadLine(), out sodaCost);

                        while (sodaCost >= 0)
                        {
                            PurchasePriceSoda price = new PurchasePriceSoda();
                            price.DespenseSoda(sodaCost);
                            newRack.RemoveACanOf("regular");
                            Console.WriteLine("Cans are being removed");
                        }
                        Console.WriteLine("The amount must be greater than zero.");
                    }
                    else if(userChoice == "diet")
                    {
                        newRack.IsFull("diet");
                        Console.WriteLine("How much does one can of soda cost?");

                        decimal sodaCost;
                        decimal.TryParse(Console.ReadLine(), out sodaCost);

                        while (sodaCost >= 0)
                        {
                            PurchasePriceSoda price = new PurchasePriceSoda();

                            price.DespenseSoda(sodaCost);
                            newRack.RemoveACanOf("diet");
                            Console.WriteLine("Cans are being removed");
                        }
                        Console.WriteLine("The amount must be greater than zero.");
                    }
                    else if(userChoice == "fanta")
                    {
                        newRack.IsFull("fanta");
                        Console.WriteLine("How much does one can of soda cost?");

                        decimal sodaCost;
                        decimal.TryParse(Console.ReadLine(), out sodaCost);

                        while (sodaCost >= 0)
                        {
                            PurchasePriceSoda price = new PurchasePriceSoda();

                            price.DespenseSoda(sodaCost);
                            newRack.RemoveACanOf("fanta");
                            Console.WriteLine("Cans are being removed");
                        }
                        Console.WriteLine("The amount must be greater than zero.");
                    }
                    else
                    {
                        Console.WriteLine("Enter regular, diet or fanta.");
                    }

                    
                    //Create a new instance of the sodaMachine object
                    //SodaMachine soda = new SodaMachine();

                    //Call the DespenseSoda() method on the class 
                    //soda.DespenseSoda();
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

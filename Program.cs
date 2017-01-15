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
                    //Create a new instance of the sodaMachine object
                    SodaMachine soda = new SodaMachine();

                    //Call the DespenseSoda() method on the class 
                    soda.DespenseSoda();
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

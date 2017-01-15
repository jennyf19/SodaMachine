using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class CanRack
    {
        private const int emptyBin = 0;
        private const int binSize = 3;

        private int regular = emptyBin;
        private int diet = emptyBin;
        private int fanta = emptyBin;

        public CanRack()
        {
            FillTheCanRack();
        }

        public void AddACanOf(string FlavorOfCanToBeAdded)
        {
            Console.WriteLine("Adding a can of {0} soda to the rack", FlavorOfCanToBeAdded);
            if (FlavorOfCanToBeAdded == "regular")
            {
                regular = regular + 1;
            }
            else if (FlavorOfCanToBeAdded == "diet")
            {
                diet = diet + 1;
            }
            else if (FlavorOfCanToBeAdded == "fanta")
            {
                fanta = fanta + 1;
            }
            else
            {
                Console.WriteLine("please enter a soda: regular, diet or fanta");
            }

        }

        public void RemoveACanOf(string FlavorOfCanToBeRemoved)
        {
            Console.WriteLine("Removing a can of {0} soda from the machine", FlavorOfCanToBeRemoved);
            if (FlavorOfCanToBeRemoved == "regular")
            {
                regular = regular - 1;
            }
            else if (FlavorOfCanToBeRemoved == "diet")
            {
                diet = diet - 1;
            }
            else if (FlavorOfCanToBeRemoved == "fanta")
            {
                diet = diet - 1;
            }
            else
            {
                Console.WriteLine("please enter a soda: regular, diet or fanta");
            }
        }

        public void FillTheCanRack()
        {
            Console.WriteLine("Adding soda to the can rack");
            regular = binSize;
            diet = binSize;
            fanta = binSize;
        }

        public void EmptyCanRackOf(string FlavorOfBinToBeEmptied)
        {
            Console.WriteLine("Removing cans from the rack of {0} soda", FlavorOfBinToBeEmptied);
            if (FlavorOfBinToBeEmptied == "regular")
            {
                regular = emptyBin;
            }

            else if (FlavorOfBinToBeEmptied == "diet")
            {
                diet = emptyBin;
            }

            else if (FlavorOfBinToBeEmptied == "fanta")
            {
                fanta = emptyBin;
            }
            else
            {
                Console.WriteLine("please enter a soda: regular, diet or fanta");
            }
        }

        public Boolean IsFull(string FlavorOfBinToCheck)
        {
            Boolean capacity = false;
            Console.WriteLine("Ok...checking to see if the can rack is full...{0} rack", FlavorOfBinToCheck);
            if (FlavorOfBinToCheck == "regular")
            {
                capacity = regular == binSize;
            }
            else if (FlavorOfBinToCheck == "diet")
            {
                capacity = diet == binSize;
            }
            else if (FlavorOfBinToCheck == "fanta")
            {
                capacity = fanta == binSize;
            }
            else
            {
                Console.WriteLine("Couldn't access the rack");
            }
            return capacity;
        }

        public Boolean IsEmpty(string FlavorOfBinToCheck)
        {
            Boolean capacity = false;
            Console.WriteLine("Ok...checking to see if the can rack is full...{0} rack", FlavorOfBinToCheck);
            if (FlavorOfBinToCheck == "regular")
            {
                capacity = regular == emptyBin;
            }
            else if (FlavorOfBinToCheck == "diet")
            {
                capacity = diet == emptyBin;
            }
            else if (FlavorOfBinToCheck == "fanta")
            {
                capacity = fanta == emptyBin;
            }
            else
            {
                Console.WriteLine("Couldn't access the rack");
            }
            return capacity;
        }
    }
}


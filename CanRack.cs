//Ferries, Jenny
//Soda Machine Exercise 05

using System;
using System.Diagnostics;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace SodaMachine
{
    class CanRack
    {
        //private int[] rack = new int[Enum.GetValues(typeof(Flavor)).Length];
        private Dictionary<Flavor, int> rack = null;
        private const int emptyBin = 0;
        private const int binSize = 3;

        private const int dummyArgument = 0;

        public CanRack()
        {
            rack = new Dictionary<Flavor, int>();
            FillTheCanRack();
        }

        public void DisplayCanRack()
        {
            foreach (Flavor flavorType in FlavorOps.AllFlavors)
            {
                Console.WriteLine("{0}\n{1}", flavorType, rack[flavorType]);
            }
        }

        public void AddACanOf(string FlavorOfCanToBeAdded)
        {
            if (IsFull(FlavorOfCanToBeAdded))
            {
                Debug.WriteLine("Failed attempt to add a can of {0} to a full rack", FlavorOfCanToBeAdded, dummyArgument);
            }
            else
            {
                Debug.WriteLine("Adding a can of {0} soda to the rack", FlavorOfCanToBeAdded, dummyArgument);
                Flavor flavorEnum = FlavorOps.ToFlavor(FlavorOfCanToBeAdded);
                rack[flavorEnum]++;
            }
        }

        //overloaded method
        public void AddACanOf(Flavor FlavorOfCanToBeAdded)
        {
            AddACanOf(FlavorOfCanToBeAdded.ToString());
        }

        public void RemoveACanOf(string FlavorOfCanToBeRemoved)
        {
            if (IsEmpty(FlavorOfCanToBeRemoved))
            {
                Debug.WriteLine("Failed to remove a can of {0} soda from the machine", FlavorOfCanToBeRemoved, dummyArgument);
            }
            else
            {
                Debug.WriteLine("please enter a soda: regular, diet or fanta");
                Flavor flavorEnum = FlavorOps.ToFlavor(FlavorOfCanToBeRemoved);
                rack[flavorEnum]--;
            }
        }

        public void RemoveACanOf(Flavor FlavorOfCanToBeRemoved)
        {
            RemoveACanOf(FlavorOfCanToBeRemoved.ToString());
        }

        public void FillTheCanRack()
        {
            Debug.WriteLine("Adding soda to the can rack");
            foreach (Flavor flavorType in FlavorOps.AllFlavors)
            {
                rack[flavorType] = binSize;
            }
        }

        public void EmptyCanRackOf(string FlavorOfBinToBeEmptied)
        {
            Flavor flavorEnum = FlavorOps.ToFlavor(FlavorOfBinToBeEmptied);
            Debug.WriteLine("Cannot remove the flavor");
            rack[flavorEnum] = emptyBin;
        }

        public void EmptyCanRackOf(Flavor FlavorOfBinToBinToBeEmptied)
        {
            EmptyCanRackOf(FlavorOfBinToBinToBeEmptied.ToString());
        }

        public Boolean IsFull(string FlavorOfBinToCheck)
        {
            Flavor flavorEnum = FlavorOps.ToFlavor(FlavorOfBinToCheck);
            Debug.WriteLine("Checking rack of {0}", FlavorOfBinToCheck, dummyArgument);
            return rack[flavorEnum] == binSize;
        }

        public Boolean IsFull(Flavor FlavorOfBinToCheck)
        {
            return IsFull(FlavorOfBinToCheck.ToString());
        }

        public Boolean IsEmpty(string FlavorOfBinToCheck)
        {
            Debug.WriteLine("Check if rack of {0} is empty", FlavorOfBinToCheck, dummyArgument);
            Flavor flavorEnum = FlavorOps.ToFlavor(FlavorOfBinToCheck);
            return rack[flavorEnum] == emptyBin;
        }

        public Boolean IsEmpty(Flavor FlavorOfBinToCheck)
        {
            return IsEmpty(FlavorOfBinToCheck.ToString());
        }
    }
}


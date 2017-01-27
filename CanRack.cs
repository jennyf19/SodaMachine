//Ferries, Jenny
//Soda Machine Exercise 02
using System;
using System.Diagnostics;

namespace SodaMachine
{
    class CanRack
    {
        private int[] rack = new int[Enum.GetValues(typeof(Flavor)).Length];
        private const int emptyBin = 0;
        private const int binSize = 3;

        //private int regular = emptyBin;
        //private int diet = emptyBin;
        //private int fanta = emptyBin;

        private const int dummyArgument = 0;

        public CanRack()
        {
            FillTheCanRack();
        }

        public void DisplayCanRack()
        {
            foreach (string flavor in Enum.GetNames(typeof(Flavor)))
            {
                Flavor flavorEnum = (Flavor)Enum.Parse(typeof(Flavor), flavor);
                int flavorType = (int)flavorEnum;
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

                Flavor flavorEnum;

                if (Enum.IsDefined(typeof(Flavor), FlavorOfCanToBeAdded))
                {
                    flavorEnum = (Flavor)Enum.Parse(typeof(Flavor), FlavorOfCanToBeAdded);
                    int flavorRack = (int)flavorEnum;
                    rack[flavorRack]++;
                }
                else
                {
                    Debug.WriteLine("please enter a soda: regular, diet or fanta");
                }
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
                Flavor flavorEnum;

                if (Enum.IsDefined(typeof(Flavor), FlavorOfCanToBeRemoved))
                {
                    flavorEnum = (Flavor)Enum.Parse(typeof(Flavor), FlavorOfCanToBeRemoved);
                    int flavorRack = (int)flavorEnum;
                    rack[flavorRack]--;
                }
                else
                {
                    Debug.WriteLine("please enter a soda: regular, diet or fanta");
                }
            }
        }

        public void RemoveACanOf(Flavor FlavorOfCanToBeRemoved)
        {
            RemoveACanOf(FlavorOfCanToBeRemoved.ToString());
        }

        public void FillTheCanRack()
        {
            Debug.WriteLine("Adding soda to the can rack");
            foreach (int flavor in Enum.GetValues(typeof(Flavor)))
            {
                rack[flavor] = binSize;
            }
        }

        public void EmptyCanRackOf(string FlavorOfBinToBeEmptied)
        {
            if (Enum.IsDefined(typeof(Flavor), FlavorOfBinToBeEmptied))
            {
                Flavor flavorDump = (Flavor)Enum.Parse(typeof(Flavor), FlavorOfBinToBeEmptied);
                rack[(int)flavorDump] = emptyBin;
            }
            else
            {
                Debug.WriteLine("Cannot remove the flavor");
            }
        }

        public void EmptyCanRackOf(Flavor FlavorOfBinToBinToBeEmptied)
        {
            EmptyCanRackOf(FlavorOfBinToBinToBeEmptied.ToString());
        }

        public Boolean IsFull(string FlavorOfBinToCheck)
        {
            Boolean capacity = false;
            Debug.WriteLine("Ok...checking to see if the can rack is full...{0} rack", FlavorOfBinToCheck);

            Flavor flavorEnum;

            if (Enum.IsDefined(typeof(Flavor), FlavorOfBinToCheck))
            {
                flavorEnum = (Flavor)Enum.Parse(typeof(Flavor), FlavorOfBinToCheck);
                int type = (int)flavorEnum;
                capacity = rack[type] == binSize;
            }
            else
            {
                Debug.WriteLine("Couldn't access the rack");
            }
            return capacity;
        }

        public Boolean IsFull(Flavor FlavorOfBinToCheck)
        {
            return IsFull(FlavorOfBinToCheck.ToString());
        }

        public Boolean IsEmpty(string FlavorOfBinToCheck)
        {
            Boolean capacity = false;
            Debug.WriteLine("Ok...checking to see if the can rack is full...{0} rack", FlavorOfBinToCheck);

            Flavor flavorEnum;

            if (Enum.IsDefined(typeof(Flavor), FlavorOfBinToCheck))
            {
                flavorEnum = (Flavor)Enum.Parse(typeof(Flavor), FlavorOfBinToCheck);
                int type = (int)flavorEnum;
                capacity = rack[type] == emptyBin;
            }
            else
            {

                Debug.WriteLine("Couldn't access the rack");
            }
            return capacity;
        }

        public Boolean IsEmpty(Flavor FlavorOfBinToCheck)
        {
            return IsEmpty(FlavorOfBinToCheck.ToString());
        }
    }
}


//Ferries, Jenny
//Soda Machine Exercise 02
using System;
using System.Diagnostics;

namespace SodaMachine
{
    class CanRack
    {
        private const int emptyBin = 0;
        private const int binSize = 3;

        private int regular = emptyBin;
        private int diet = emptyBin;
        private int fanta = emptyBin;

        private const int dummyArgument = 0;

        public CanRack()
        {
            FillTheCanRack();
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
                Debug.WriteLine("Removing a can of {0} soda from the empty rack", FlavorOfCanToBeRemoved, dummyArgument);
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
            regular = binSize;
            diet = binSize;
            fanta = binSize;
        }

        public void EmptyCanRackOf(string FlavorOfBinToBeEmptied)
        {
            Debug.WriteLine("Removing cans from the rack of {0} soda", FlavorOfBinToBeEmptied, dummyArgument);
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
                Debug.WriteLine("please enter a soda: regular, diet or fanta");
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


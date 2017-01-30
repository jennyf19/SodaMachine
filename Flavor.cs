//Ferries, Jenny
//Soda Machine Exercise 05

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace SodaMachine
{
    enum Flavor { regular, diet, fanta }

    static class FlavorOps
    {
        private static List<Flavor> _allFlavors = new List<Flavor>();

        static FlavorOps()
        {
            foreach (string flavorName in Enum.GetNames(typeof(Flavor)))
            {
                Flavor flavorEnum = ToFlavor(flavorName);
                _allFlavors.Add(flavorEnum);
            }
        }
        public static Flavor ToFlavor(string FlavorName)
        {
            Flavor type = Flavor.regular;
            if (Enum.IsDefined(typeof(Flavor), FlavorName))
            {
                type = (Flavor)Enum.Parse(typeof(Flavor), FlavorName);
            }
            else
            {
                Debug.WriteLine("Incorrect input");
            }
            return type;
        }

        public static List<Flavor> AllFlavors
        {
            get
            {
                return _allFlavors;
            }
        }
    }
}

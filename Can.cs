//Ferries, Jenny
//Soda Machine Exercise 02

namespace SodaMachine
{
    class Can
    {
        public enum Flavor
        {
            regular, 
            diet,
            fanta
        }

        public readonly Flavor TheFlavor = Flavor.regular;

        public Can()
        {

        }

        public Can (Flavor AFlavor)
        {
            TheFlavor = AFlavor;
        }
    }
}

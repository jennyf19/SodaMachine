//Ferries, Jenny
//Soda Machine Exercise 02

namespace SodaMachine
{
    public enum Flavor
    {
        regular,
        diet,
        fanta
    }

    class Can
    {
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

namespace Weapons
{
    public class Patron
    {
        public float Caliber { get; private set; }
        public TypePatron TypePatron { get; private set; }

        public Patron(float caliber, TypePatron typePatron)
        {
            Caliber = caliber;
            TypePatron = typePatron;
        }
    }
}
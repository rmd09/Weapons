namespace Weapons
{
    public class RiflePatron : Patron
    {
        public override TypePatron TypePatron { get; } = TypePatron.RiflePatron;
        public override float Caliber { get; } = 7.62f;
    }
}

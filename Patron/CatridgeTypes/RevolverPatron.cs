namespace Weapons
{
    public class RevolverPatron : Patron
    {
        public override TypePatron TypePatron { get; } = TypePatron.RevolverPatron;
        public override float Caliber { get; } = 7.62f;
    }
}

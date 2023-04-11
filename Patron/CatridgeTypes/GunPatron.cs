namespace Weapons
{
    public class GunPatron : Patron
    {
        public override TypePatron TypePatron { get; } = TypePatron.GunPatron;
        public override float Caliber { get; } = 9f;
    }
}

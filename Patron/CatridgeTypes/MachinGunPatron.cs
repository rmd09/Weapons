namespace Weapons
{
    public class MachinGunPatron : Patron
    {
        public override TypePatron TypePatron { get; } = TypePatron.MachineGunPatron;
        public override float Caliber { get; } = 12.7f;
    }
}

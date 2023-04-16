namespace Weapons
{
    public class Revolver : Weapon
    {
        public override TypePatron TypePatron { get; } = TypePatron.RevolverPatron;
        protected override string itemType { get; } = "Револьвер";
        public Revolver(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }
    }
}

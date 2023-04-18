namespace Weapons
{
    public class Revolver : Weapon
    {
        public override TypePatron TypePatron => TypePatron.RevolverPatron;
        protected override string itemType => "Револьвер";
        public Revolver(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }
    }
}

namespace Weapons
{
    public class Revolver : Weapon
    {
        public override bool IsAutoRechargable => true;
        public override float Caliber => 7.62f;
        public override int Damage => 15;
        public override TypePatron TypePatron => TypePatron.RevolverPatron;
        public override string ItemType => "Револьвер";
        public Revolver(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }
    }
}

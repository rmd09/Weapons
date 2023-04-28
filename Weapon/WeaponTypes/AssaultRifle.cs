namespace Weapons
{
    public class AssaultRifle : Weapon
    {
        public override bool IsAutoRechargable => true;
        public override float Caliber => 7.62f;
        public override int Damage => 15;
        public override TypePatron TypePatron => TypePatron.RiflePatron;
        public override string ItemType => "Штурмовая винтовка (автомат)";
        public AssaultRifle(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }
    }
}
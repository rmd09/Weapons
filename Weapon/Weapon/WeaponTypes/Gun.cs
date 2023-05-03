namespace Weapons
{
    public class Gun : Weapon
    {
        public override bool IsAutoRechargable => true;
        public override float Caliber => 9f;
        public override int Damage => 20;
        public override TypePatron TypePatron => TypePatron.GunPatron;
        public override string ItemType => "Пистолет";

        public Gun(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }

    }
}
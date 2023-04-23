namespace Weapons
{
    public class Gun : Weapon
    {
        public override float Caliber => 9f;
        public override int Damage => 20;
        public override TypePatron TypePatron => TypePatron.GunPatron;
        protected override string itemType => "Пистолет";

        public Gun(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }

    }
}
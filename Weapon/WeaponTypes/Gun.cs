namespace Weapons
{
    public class Gun : Weapon
    {
        public override TypePatron TypePatron => TypePatron.GunPatron;
        protected override string itemType => "Пистолет";

        public Gun(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }

    }
}
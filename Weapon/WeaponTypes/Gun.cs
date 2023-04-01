namespace Weapons
{
    public class Gun : Weapon
    {
        public override int MagazineSize { get; } = 6;

        public Gun(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }

        public override TypePatron TypePatron { get; } = TypePatron.GunPatron;
        protected override string itemType { get; } = "Пистолет";
    }
}

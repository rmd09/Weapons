namespace Weapons
{
    public class Rifle : Weapon
    {
        public override float Caliber => 7.62f;
        public override int Damage => 30;
        public override TypePatron TypePatron => TypePatron.RiflePatron;
        public override string ItemType => "Винтовка";
        public Rifle(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }
    }
}

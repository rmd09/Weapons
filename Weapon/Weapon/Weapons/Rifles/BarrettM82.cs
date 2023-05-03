namespace Weapons
{
    public class BarrettM82 : Rifle
    {
        public override float Caliber => 12.7f;
        public override int Damage => base.Damage + 15;
        public override int MagazineSize => 17;
        private const string descriptionKey = "BarrettM82";
        public override string Description => SetDescription(pathJsonDescription, descriptionKey);
        public BarrettM82(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }
    }
}

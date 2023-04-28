namespace Weapons
{
    public class DragunovSniperRifle : Rifle
    {
        public override int Damage => base.Damage + 10;
        public override int MagazineSize => 10;
        private const string descriptionKey = "DragunovSniperRifle";
        public override string Description => SetDescription(pathJsonDescription, descriptionKey);
        public DragunovSniperRifle(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }
    }
}

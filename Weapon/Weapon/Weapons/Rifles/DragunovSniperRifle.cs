namespace Weapons
{
    public class DragunovSniperRifle : Rifle
    {
        public override int Damage => base.Damage + 10;
        public override int MagazineSize => 10;
        public override string DescriptionKey => "DragunovSniperRifle";
        public override string Name { get; } = "Снайперская винтовка Драгунова";
        public override string Description => SetDescription(pathJsonDescription, DescriptionKey);
        public DragunovSniperRifle(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }
    }
}

namespace Weapons
{
    public class WebleyRevolver : Revolver
    {
        public override int MagazineSize => 6;
        public override string DescriptionKey => "WebleyRevolver";
        public override string Name { get; } = "Револьвер Веблера";
        public override string Description => SetDescription(pathJsonDescription, DescriptionKey);

        public WebleyRevolver(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }
    }
}

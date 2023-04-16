namespace Weapons
{
    public class WebleyRevolver : Revolver
    {
        public override int MagazineSize { get; } = 6;
        private const string descriptionKey = "WebleyRevolver";
        protected override string description { get; } = SetDescription(pathJsonDescription, descriptionKey);

        public WebleyRevolver(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }
    }
}

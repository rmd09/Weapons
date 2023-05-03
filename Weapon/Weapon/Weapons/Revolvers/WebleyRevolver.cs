namespace Weapons
{
    public class WebleyRevolver : Revolver
    {
        public override int MagazineSize => 6;
        private const string descriptionKey = "WebleyRevolver";
        public override string Description => SetDescription(pathJsonDescription, descriptionKey);

        public WebleyRevolver(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }
    }
}

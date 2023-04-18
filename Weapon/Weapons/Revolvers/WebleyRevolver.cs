namespace Weapons
{
    public class WebleyRevolver : Revolver
    {
        public override int MagazineSize => 6;
        private const string descriptionKey = "WebleyRevolver";
        protected override string description => SetDescription(pathJsonDescription, descriptionKey);

        public WebleyRevolver(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }
    }
}

namespace Weapons
{
    public class Glock17 : Gun
    {
        public override int MagazineSize => 17;
        private const string descriptionKey = "Glock17";
        protected override string description => SetDescription(pathJsonDescription, descriptionKey);

        public Glock17(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }
    }
}

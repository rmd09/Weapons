namespace Weapons
{
    public class Glock17 : Gun
    {
        public override int Damage => base.Damage + 10;
        public override int MagazineSize => 17;
        private const string descriptionKey = "Glock17";
        public override string Description => SetDescription(pathJsonDescription, descriptionKey);

        public Glock17(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }
    }
}

namespace Weapons
{
    public class AK_47 : AssaultRifle
    {
        public override int Damage => base.Damage + 10;
        public override int MagazineSize => 17;
        private const string descriptionKey = "AK_47";
        public override string Description => SetDescription(pathJsonDescription, descriptionKey);
        public AK_47(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }
    }
}

namespace Weapons
{
    public class AC_VAL : AssaultRifle
    {
        public override int Damage => base.Damage + 5;
        public override int MagazineSize => 20;
        private const string descriptionKey = "AC_VAL";
        public override string Description => SetDescription(pathJsonDescription, descriptionKey);
        public AC_VAL(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }
    }
}

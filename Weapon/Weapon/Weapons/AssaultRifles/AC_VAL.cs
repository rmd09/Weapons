namespace Weapons
{
    public class AC_VAL : AssaultRifle
    {
        public override int Damage => base.Damage + 5;
        public override int MagazineSize => 20;
        public override string DescriptionKey => "AC_VAL";
        public override string Name { get; } = "АС Вал";
        public override string Description => SetDescription(pathJsonDescription, DescriptionKey);
        public AC_VAL(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }
    }
}

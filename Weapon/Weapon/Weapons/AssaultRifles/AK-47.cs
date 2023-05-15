namespace Weapons
{
    public class AK_47 : AssaultRifle
    {
        public override int Damage => base.Damage + 10;
        public override int MagazineSize => 17;
        public override string DescriptionKey => "AK_47";
        public override string Name { get; } = "АК-47";
        public override string Description => SetDescription(pathJsonDescription, DescriptionKey);
        public AK_47(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }
    }
}

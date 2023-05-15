namespace Weapons
{
    public class BarrettM82 : Rifle
    {
        public override float Caliber => 12.7f;
        public override int Damage => base.Damage + 15;
        public override int MagazineSize => 17;
        public override string DescriptionKey => "BarrettM82";
        public override string Name { get; } = "BarrettM82";
        public override string Description => SetDescription(pathJsonDescription, DescriptionKey);
        public BarrettM82(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }
    }
}

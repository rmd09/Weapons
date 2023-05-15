namespace Weapons
{
    public class Glock17 : Gun
    {
        public override int Damage => base.Damage + 10;
        public override int MagazineSize => 17;
        public override string DescriptionKey => "Glock17";
        public override string Name { get; } = "Глок 17";
        public override string Description => SetDescription(pathJsonDescription, DescriptionKey);

        public Glock17(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }
    }
}

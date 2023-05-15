namespace Weapons
{
    public class NaganaSystemRevolver : Revolver
    {
        public override int MagazineSize => 7;

        public override string DescriptionKey => "NaganaSystemRevolver";
        public override string Name { get; } = "Револьвер системы Нагана";
        public override string Description => SetDescription(pathJsonDescription, DescriptionKey);
        public NaganaSystemRevolver(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }
    }
}

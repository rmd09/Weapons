namespace Weapons
{
    public class NaganaSystemRevolver : Revolver
    {
        public override int MagazineSize { get; } = 7;

        private const string descriptionKey = "NaganaSystemRevolver";
        protected override string description { get; } = SetDescription(pathJsonDescription, descriptionKey);
        public NaganaSystemRevolver(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }
    }
}

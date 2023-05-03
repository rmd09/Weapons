namespace Weapons
{
    public class NaganaSystemRevolver : Revolver
    {
        public override int MagazineSize => 7;

        private const string descriptionKey = "NaganaSystemRevolver";
        public override string Description => SetDescription(pathJsonDescription, descriptionKey);
        public NaganaSystemRevolver(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }
    }
}

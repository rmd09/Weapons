namespace Weapons
{
    public class DT : MachineGun
    {
        public override float Caliber => 7.62f;
        public override int Damage => base.Damage + 10;
        public override int MagazineSize => 47;
        public const string descriptionKey = "DT";
        public override string Description => SetDescription(pathJsonDescription, descriptionKey);
        public DT(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }
    }
}

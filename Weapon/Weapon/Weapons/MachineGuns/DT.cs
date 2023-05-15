namespace Weapons
{
    public class DT : MachineGun
    {
        public override float Caliber => 7.62f;
        public override int Damage => base.Damage + 10;
        public override int MagazineSize => 47;
        public override string DescriptionKey => "DT";
        public override string Name { get; } = "ДТ";
        public override string Description => SetDescription(pathJsonDescription, DescriptionKey);
        public DT(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }
    }
}

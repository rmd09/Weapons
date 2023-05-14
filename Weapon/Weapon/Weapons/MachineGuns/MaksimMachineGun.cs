namespace Weapons
{
    public class MaksimMachineGun : MachineGun
    {
        public override int Damage => base.Damage + 10;
        public override int MagazineSize => 50;
        public override string DescriptionKey => "MaksimMachineGun";
        public override string Description => SetDescription(pathJsonDescription, DescriptionKey);
        public MaksimMachineGun(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }
    }
}

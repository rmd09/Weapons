namespace Weapons
{
    public class MaksimMachineGun : MachineGun
    {
        public override int Damage => base.Damage + 10;
        public override int MagazineSize => 50;
        private const string descriptionKey = "MaksimMachineGun";
        public override string Description => SetDescription(pathJsonDescription, descriptionKey);
        public MaksimMachineGun(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }
    }
}

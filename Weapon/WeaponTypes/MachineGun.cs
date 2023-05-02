namespace Weapons
{
    public class MachineGun : Weapon
    {
        public override bool IsAutoRechargable => true;
        public override float Caliber => 12.7f;
        public override int Damage => 20;
        public override TypePatron TypePatron => TypePatron.MachineGunPatron;
        public override string ItemType => "Пулемёт";
        public MachineGun(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }
    }
}

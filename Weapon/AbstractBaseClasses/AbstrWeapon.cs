namespace Weapons
{
    public delegate void Shooting();

    public abstract class AbstrWeapon : IWeapon
    {
        public abstract int Damage { get; }
        public abstract bool IsAutoRechargable { get; }
        public abstract int MagazineSize { get; }
        public static string Information { get; protected set; } = "Тип инвентаря - ОРУЖИЕ";
        protected bool isRecharged = false;
        protected Magazine<Cartridge> magazine;
        private static event Shooting shooting = () => { };

        public virtual void Shoot()
        {
            if (isRecharged)
            {
                shooting();
            }
        }
        public abstract void Recharge();
        public abstract void InsertMagazine(Magazine<Cartridge> magazine);
        public abstract Magazine<Cartridge> TakeMagazine();
        public static void SetShooting(Shooting shooting)
        {
            AbstrWeapon.shooting = shooting ?? (() => { });
        }
        public override string ToString()
        {
            return Information;
        }
    }
}
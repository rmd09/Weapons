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
        protected Magazine magazine;
        protected event Shooting shooting;

        public virtual void Shoot()
        {
            if (isRecharged)
            {
                this?.shooting();
            }
        }
        public abstract void Recharge();
        public abstract void InsertMagazine(Magazine magazine);
        public abstract Magazine TakeMagazine();
        public void SetShooting(Shooting shooting)
        {
            this.shooting = shooting;
        }
        public override string ToString()
        {
            return Information;
        }
    }
}
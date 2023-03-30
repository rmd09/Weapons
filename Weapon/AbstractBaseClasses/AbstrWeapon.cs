namespace Weapons
{
    public delegate void Shooting();

    public abstract class AbstrWeapon : IWeapon
    {
        public abstract int Damage { get; }
        public abstract bool IsAutoRechargable { get; }
        public abstract int MagazineSize { get; }
        public Info Information { get; protected set; }
        protected bool isRecharged = false;
        protected Magazine magazine;
        public static event Shooting Shooting = () => { };

        public void Shoot()
        {
            if (isRecharged)
            {
                Shooting();
            }
        }
        public abstract void Recharge();
        public abstract void InsertMagazine(Magazine magazine);
        public abstract Magazine TakeMagazine();
        public override string ToString()
        {
            return Information.ToString();
        }
    }
}
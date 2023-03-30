namespace Weapons
{
    public delegate void Shooting();

    public abstract class AbstrWeapon : IWeapon
    {
        private const GlobalType GLOBAL_TYPE = GlobalType.Оружее;
        protected abstract string itemType { get; }
        protected abstract string description { get; }

        public abstract int Damage { get; }
        public abstract bool IsAutoRechargable { get; }
        public abstract int MagazineSize { get; }
        public Info Information { get; protected set; }
        protected bool isRecharged = false;
        protected Magazine magazine;
        public abstract TypePatron TypePatron { get; }
        public static event Shooting Shooting = () => { };

        public AbstrWeapon()
        {
            magazine = new Magazine(MagazineSize);
            Information = new Info(GLOBAL_TYPE, itemType, description);
        }

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
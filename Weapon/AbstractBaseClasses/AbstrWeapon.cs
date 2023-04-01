namespace Weapons
{
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
        public event EventHandler<ShootingArgs> Shooting = (s, e) => { };

        public AbstrWeapon(EventHandler<ShootingArgs> shooting)
        {
            magazine = new Magazine(MagazineSize);
            Information = new Info(GLOBAL_TYPE, itemType, description);
            Shooting = shooting;
        }

        public void Shoot()
        {
            if (isRecharged)
            {
                try
                {
                    magazine.Shoot();
                    ShootingArgs eventArgs = new ShootingArgs(Damage, TypePatron);
                    Shooting(this, eventArgs);
                }
                catch 
                {
                }
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
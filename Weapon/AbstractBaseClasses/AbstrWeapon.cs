namespace Weapons
{
    public abstract class AbstrWeapon : IWeapon
    {
        protected const GlobalType GLOBAL_TYPE = GlobalType.Оружее;
        protected abstract string itemType { get; }
        protected abstract string description { get; }

        public abstract int Damage { get; }
        public abstract bool IsAutoRechargable { get; }
        public abstract int MagazineSize { get; }
        public int NumberOfPatrons { get; private set; }
        public Info Information { get; protected set; }
        protected bool isRecharged = false;
        protected Magazine magazine;
        public abstract TypePatron TypePatron { get; }

        public event EventHandler<ShootingArgs> Shooting = (s, e) => { };

        public AbstrWeapon(EventHandler<ShootingArgs> shooting)
        {
            magazine = new Magazine(MagazineSize);
            NumberOfPatrons = MagazineSize;
            if (shooting != null)
                Shooting = shooting;
        }

        public void Shoot()
        {
            if (isRecharged && NumberOfPatrons > 0)
            {
                magazine.Shoot();
                ShootingArgs eventArgs = new ShootingArgs(Damage, TypePatron);
                Shooting(this, eventArgs);
                NumberOfPatrons--;
                isRecharged = IsAutoRechargable ? true : false;
            }
        }
        public void Recharge()
        {
            isRecharged = true;
        }
        public void InsertMagazine(Magazine magazine)
        {
            if (this.magazine == null && magazine != null && MagazineSize == magazine.MagazineSize && magazine.TypePatron == TypePatron)
            {
                this.magazine = magazine;
                NumberOfPatrons = magazine.MagazineSize;
            }
        }
        public Magazine TakeMagazine()
        {
            var resMagazine = magazine;
            magazine = null;
            isRecharged = false;
            NumberOfPatrons = 0;
            return resMagazine;
        }
        public override string ToString()
        {
            return Information.ToString();
        }
    }
}
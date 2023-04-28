namespace Weapons
{
    public abstract class AbstrWeapon : IWeapon
    {
        public GlobalType GlobalType { get; } = GlobalType.Оружие;
        public abstract string ItemType { get; }
        public abstract string Description { get; }

        public abstract int Damage { get; }
        public abstract float Caliber { get; }
        public abstract bool IsAutoRechargable { get; }
        public abstract int MagazineSize { get; }
        public int NumberOfPatrons { get; private set; }

        protected bool isRecharged = false;
        protected Magazine magazine;
        public abstract TypePatron TypePatron { get; }

        public event EventHandler<ShootingArgs> Shooting = (s, e) => { };

        public AbstrWeapon(EventHandler<ShootingArgs> shooting)
        {
            magazine = new Magazine(MagazineSize, TypePatron, Caliber);
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
            return $"Предмет: {GlobalType}\nТип: {ItemType}\nОписание: {Description}";
        }
    }
}
namespace Weapons
{
    public abstract class AbstrWeapon : IWeapon
    {
        public GlobalType GlobalType => GlobalType.Оружие;
        public abstract string ItemType { get; }
        public abstract string Description { get; }

        public abstract int Damage { get; }
        public abstract float Caliber { get; }
        public abstract bool IsAutoRechargable { get; }
        public abstract int MagazineSize { get; }
        public int NumberOfPatrons { get; private set; } = 0;
        public bool IsThereMagazine { get; private set; } = false;

        public bool IsRecharged { get; private set; } = false;
        protected Magazine magazine;
        public abstract TypePatron TypePatron { get; }
        public abstract string DescriptionKey { get; }

        public event EventHandler<ShootingArgs> Shooting = (s, e) => { };

        public AbstrWeapon(EventHandler<ShootingArgs> shooting)
        {
            if (shooting != null)
                Shooting = shooting;
        }

        public void Shoot()
        {
            if (IsRecharged && NumberOfPatrons > 0)
            {
                magazine.Shoot();
                ShootingArgs eventArgs = new ShootingArgs(Damage, TypePatron);
                Shooting(this, eventArgs);
                NumberOfPatrons--;
                IsRecharged = IsAutoRechargable ? true : false;
            }
        }
        public void Recharge()
        {
            IsRecharged = true;
        }
        public void InsertMagazine(Magazine magazine)
        {
            if (this.magazine == null && magazine != null && MagazineSize == magazine.MagazineSize && magazine.TypePatron == TypePatron)
            {
                this.magazine = magazine;
                NumberOfPatrons = magazine.MagazineSize;
                IsThereMagazine = true;
            }
        }
        public Magazine TakeMagazine()
        {
            IsThereMagazine = false;
            var resMagazine = magazine;
            magazine = null;
            IsRecharged = false;
            NumberOfPatrons = 0;
            return resMagazine;
        }
        public override string ToString()
        {
            return $"Предмет: {GlobalType}\nТип: {ItemType}\nОписание: {Description}";
        }
    }
}
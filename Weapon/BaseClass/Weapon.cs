namespace Weapons
{
    public class Weapon : AbstrWeapon
    {
        public override int Damage { get; } = 1;
        public override bool IsAutoRechargable { get; } = false;
        public override int MagazineSize { get; } = 1;

        public Weapon()
        {
            magazine = new Magazine(MagazineSize);
        }

        public override void Recharge()
        {
            isRecharged = true;
        }
        public override void InsertMagazine(Magazine magazine)
        {
            if (this.magazine == null && MagazineSize == magazine.MagazineSize)
            {
                this.magazine = magazine;
            }
        }
        public override Magazine TakeMagazine()
        {
            var resMagazine = magazine;
            magazine = null;
            isRecharged = false;
            return resMagazine;
        }
    }
}

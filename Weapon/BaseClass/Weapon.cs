namespace Weapons
{
    public class Weapon : AbstrWeapon
    {
        public override int Damage { get; }
        public override bool IsAutoRechargable { get; } = false;
        public override int MagazineSize { get; }

        public override void Recharge()
        {
            isRecharged = true;
        }
        public override void InsertMagazine(Magazine<Cartridge> magazine)
        {
            if (this.magazine == null && MagazineSize == magazine.MagazineSize)
            {
                this.magazine = magazine;
            }
        }
        public override Magazine<Cartridge> TakeMagazine()
        {
            var resMagazine = magazine;
            magazine = null;
            isRecharged = false;
            return resMagazine;
        }
    }
}

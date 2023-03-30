namespace Weapons
{
    public class Weapon : AbstrWeapon
    {
        protected override string itemType { get; }
        protected override string description { get; }

        public override int Damage { get; } = 1;
        public override bool IsAutoRechargable { get; } = false;
        public override int MagazineSize { get; } = 1;
        public override TypePatron TypePatron { get; } = TypePatron.BaseClassPatron;

        public override void Recharge()
        {
            isRecharged = true;
        }
        public override void InsertMagazine(Magazine magazine)
        {
            if (this.magazine == null && MagazineSize == magazine.MagazineSize && magazine.TypePatron == TypePatron)
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

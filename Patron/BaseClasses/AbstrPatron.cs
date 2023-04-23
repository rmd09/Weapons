namespace Weapons
{    public abstract class AbstrPatron : IItem
    {
        private const GlobalType GLOBAL_TYPE_CARTRIDGE = GlobalType.Патрон;

        public abstract float Caliber { get; }

        #region Information
        public Info Information { get; private set; }
        protected abstract string itemType { get; }
        protected abstract string description { get; }
        public abstract TypePatron TypePatron { get; }
        #endregion

        public AbstrPatron()
        {
            Information = new WeaponAndPatronInfo(GLOBAL_TYPE_CARTRIDGE, itemType, description, TypePatron);
        }

        public override string ToString()
        {
            return Information.ToString();
        }
    }
}

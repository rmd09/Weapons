namespace Weapons
{
    public abstract class AbstrPatron : IItem
    {
        private const GlobalType GLOBAL_TYPE_CARTRIDGE = GlobalType.Патрон;

        public abstract int Caliber { get; }

        #region Information
        public Info Information { get; private set; }
        protected abstract string itemType { get; }
        protected abstract string description { get; }
        #endregion

        public AbstrPatron()
        {
            Information = new Info(GLOBAL_TYPE_CARTRIDGE, itemType, description);
        }

        public override string ToString()
        {
            return Information.ToString();
        }
    }
}

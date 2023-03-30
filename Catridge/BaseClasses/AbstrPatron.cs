namespace Weapons
{
    public abstract class AbstrPatron : IItem
    {
        private const string GLOBAL_TYPE_CARTRIDGE = "Патрон";

        public abstract int Caliber { get; }

        public Info Information { get; private set; }
        protected abstract string itemType { get; }
        protected abstract string description { get; }

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

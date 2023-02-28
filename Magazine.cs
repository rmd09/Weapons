namespace Weapons
{
    public class Magazine
    {
        private Cartridge[] cartridges;
        public int MagazineSize { get; }
        public int NumberOfCartridges { get; private set; }

        public Magazine(Cartridge[] cartridges)
        {
            this.cartridges = cartridges;

        }
    }
}

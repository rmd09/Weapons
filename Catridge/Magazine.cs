namespace Weapons
{
    public class Magazine
    {
        private Cartridge[] cartridges;
        public int MagazineSize { get; private set; }

        public Magazine(Cartridge[] cartridges)
        {
            this.cartridges = cartridges;
            MagazineSize = cartridges.Length;
        }
    }
}

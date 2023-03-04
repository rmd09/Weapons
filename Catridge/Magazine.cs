namespace Weapons
{
    public class Magazine<T> where T : Cartridge
    {
        private T[] cartridges;
        public int MagazineSize { get; private set; } = 0;

        public Magazine(Cartridge[] cartridges)
        {
            if (cartridges is T[])
            {
                this.cartridges = (T[])cartridges;
                MagazineSize = cartridges.Length;
            }
        }
    }
}

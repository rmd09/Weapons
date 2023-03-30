namespace Weapons
{
    public class Magazine
    {
        private Stack<AbstrPatron> cartridges;
        public int MagazineSize { get; private set; } = 0;
        public Type typePatron { get; private set; }

        public Magazine(int magazineSize)
        {
            MagazineSize = magazineSize;
        }

        public void FillMagazine<T>() where T : AbstrPatron
        {
            cartridges.Clear();

            T[] newCartridges = new T[MagazineSize];
            foreach (AbstrPatron item in newCartridges)
            {
                cartridges.Push(item);
            }
        }

        public void Shoot()
        {
            cartridges.Pop();
        }
    }
}

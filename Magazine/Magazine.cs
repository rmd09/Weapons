namespace Weapons
{
    public class Magazine
    {
        private Stack<AbstrPatron> cartridges;
        private Type typePatron;
        public int MagazineSize { get; private set; } = 0;
        public TypePatron TypePatron { get; private set; }

        public Magazine(int magazineSize)
        {
            MagazineSize = magazineSize;
            cartridges = new Stack<AbstrPatron>();
        }

        public void FillMagazine<T>() where T : AbstrPatron
        {
            cartridges.Clear();
            typePatron = typeof(T);

            T[] newCartridges = new T[MagazineSize];
            foreach (AbstrPatron item in newCartridges)
            {
                cartridges.Push(item);
            }

            IdentificateTypePatron();
        }

        private void IdentificateTypePatron() 
        {
            if (typePatron.BaseType != typeof(Patron) && typePatron.BaseType != typeof(AbstrPatron))
                throw new ArgumentException("Тип не наследуется от Patron");

            if (typePatron == typeof(GunPatron))
                TypePatron = TypePatron.GunPatron;
            else if (typePatron == typeof(RevolverPatron))
                TypePatron = TypePatron.RevolverPatron;
            else if (typePatron == typeof(RiflePatron))
                TypePatron = TypePatron.RevolverPatron;
            else if (typePatron == typeof(MachinGunPatron))
                TypePatron = TypePatron.MachineGunPatron;
            else if (typePatron == typeof(Patron))
                TypePatron = TypePatron.BaseClassPatron;
        }

        public void Shoot()
        {
            cartridges.Pop();
        }
    }
}

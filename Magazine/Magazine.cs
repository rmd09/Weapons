namespace Weapons
{
    public class Magazine
    {
        private Stack<Patron> cartridges;
        public int MagazineSize { get; private set; }
        public TypePatron TypePatron { get; private set; }

        public Magazine(int magazineSize, TypePatron typePatron, float caliber = -1f)
        {
            if (caliber == -1f)
                caliber = ChooseDefaultCaliber(typePatron);

            TypePatron = typePatron;

            cartridges = new Stack<Patron>(MagazineSize);
            for (int i = 0; i < MagazineSize; i++)
            {
                cartridges.Push(new Patron(caliber, typePatron));
            }
        }

        private float ChooseDefaultCaliber(TypePatron typePatron)
        {
            switch (typePatron)
            {
                case TypePatron.BasePatron:
                    return 1f;

                case TypePatron.GunPatron:
                    return 9f;

                case TypePatron.RevolverPatron:
                    return 7.14f;

                case TypePatron.RiflePatron:
                    return 7.62f;

                case TypePatron.MachineGunPatron:
                    return 12.7f;

                default:
                    throw new ArgumentNullException();
            }
        }

        public void Shoot()
        {
            cartridges.Pop();
        }
    }
}

namespace Weapons
{
    public class Patron : AbstrPatron
    {
        public override float Caliber { get; } = 1;
        public override TypePatron TypePatron { get; } = TypePatron.BasePatron;

        protected override string itemType { get; }
        protected override string description { get; }

        public Patron()
        {
            
        }

        public static (float, string) GetCaliberAndTypePatron(TypePatron typePatron)
        {
            switch (typePatron)
            {
                case TypePatron.BasePatron:
                    return (1f, "Стандартный патрон");

                case TypePatron.GunPatron:
                    return (9f, "Пистолетный патрон");

                case TypePatron.RevolverPatron:
                    return (7.14f, "револьверный патрон");

                case TypePatron.RiflePatron:
                    return (7.62f, "Винтовочный патрон");

                case TypePatron.MachineGunPatron:
                    return (12.7f, "Пулемётный патрон");

                default:
                    throw new NotImplementedException("Тип патрона не определён");
            }
        }
    }
}

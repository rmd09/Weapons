namespace Weapons
{
    public class Patron
    {
        public float Caliber { get; private set; }
        public TypePatron TypePatron { get; private set; }

        public Patron(float caliber, TypePatron typePatron)
        {
            Caliber = caliber;
            TypePatron = typePatron;
        }

        public static string GetTypePatronName(TypePatron typePatron)
        {
            switch (typePatron)
            {
                case TypePatron.BasePatron:
                    return "Базовый патрон";

                case TypePatron.GunPatron:
                    return "Пистолетный патрон";

                case TypePatron.RevolverPatron:
                    return "Револьверный патрон";

                case TypePatron.RiflePatron:
                    return "Автоматный патрон";

                case TypePatron.MachineGunPatron:
                    return "Пулемётный патрон";
            }

            throw new NotImplementedException();
        }
    }
}
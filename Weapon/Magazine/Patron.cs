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
                    return "������� ������";

                case TypePatron.GunPatron:
                    return "����������� ������";

                case TypePatron.RevolverPatron:
                    return "������������ ������";

                case TypePatron.RiflePatron:
                    return "���������� ������";

                case TypePatron.MachineGunPatron:
                    return "��������� ������";
            }

            throw new NotImplementedException();
        }
    }
}
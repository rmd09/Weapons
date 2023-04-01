namespace Weapons
{
    public class ShootingArgs
    {
        public int Damage { get; private set; }
        public TypePatron TypePatron { get; private set; }

        public ShootingArgs(int damage, TypePatron typePatron)
        {
            Damage = damage;
            TypePatron = typePatron;
        }
    }
}

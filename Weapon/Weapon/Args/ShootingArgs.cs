namespace Weapons
{
    public class ShootingArgs
    {
        public int Damage { get; private set; }
        public TypePatron TypePatron { get; private set; }
        public string Name { get; private set; }

        public ShootingArgs(int damage, TypePatron typePatron, string name)
        {
            Damage = damage;
            TypePatron = typePatron;
        }
    }
}

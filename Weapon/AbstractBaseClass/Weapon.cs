namespace Weapons
{
    public abstract class Weapon
    {
        public abstract int Damage { get; }
        private Magazine magazine;

        public abstract void Shoot();
    }
}
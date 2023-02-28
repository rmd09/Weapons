namespace Weapons
{
    public abstract class Cartridge
    {
        private readonly int caliber;
        public int Caliber
        {
            get
            {
                return caliber;
            }
        }

        public Cartridge(int caliber)
        {
            this.caliber = caliber;
        }
    }
}

namespace Weapons
{
    public class Patron : AbstrPatron
    {
        public override int Caliber { get; } = 1;

        protected override string itemType => throw new NotImplementedException();
        protected override string description => throw new NotImplementedException();

        public Patron()
        {
            
        }
    }
}

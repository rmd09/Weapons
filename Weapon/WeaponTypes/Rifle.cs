namespace Weapons
{
    public class Rifle : Weapon
    {
        public override bool IsAutoRechargable { get; }

        static Rifle()
        {
            Information += "\nВинтовка";
        }
    }
}

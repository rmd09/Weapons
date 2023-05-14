using Weapons;

namespace Program
{
    public class DescritionEditor
    {
        public Weapon WeaponChoosingNow { get; private set; }

        private static List<Weapon> weapons;
        private event EventHandler<ShootingArgs> shooting = (s, e) => { };

        public DescritionEditor()
        {

            weapons = new List<Weapon>(10);
            weapons.Add(new Glock17(shooting));
            weapons.Add(new GunMakarova(shooting));
            weapons.Add(new NaganaSystemRevolver(shooting));
            weapons.Add(new WebleyRevolver(shooting));
            weapons.Add(new BarrettM82(shooting));
            weapons.Add(new DragunovSniperRifle(shooting));
            weapons.Add(new AC_VAL(shooting));
            weapons.Add(new AK_47(shooting));
            weapons.Add(new DT(shooting));
            weapons.Add(new MaksimMachineGun(shooting));
        }

        public Weapon GetWeapon(string name)
        {
            foreach (Weapon weapon in weapons)
            {
                if (weapon.)
            }
        }
    }
}

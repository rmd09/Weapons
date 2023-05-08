using Weapons;

namespace Program
{
    public class DescritionEditor
    {
        private static Dictionary<string, Weapon> weapons;
        private event EventHandler<ShootingArgs> shooting = (s, e) => { };

        public DescritionEditor()
        {

            weapons = new Dictionary<string, Weapon>(10);
            weapons.Add("Glock17", new Glock17(shooting));
            weapons.Add("GunMakarova", new GunMakarova(shooting));
            weapons.Add("NaganaSystemRevolver", new NaganaSystemRevolver(shooting));
            weapons.Add("WebleyRevolver", new WebleyRevolver(shooting));
            weapons.Add("BarrettM82", new BarrettM82(shooting));
            weapons.Add("DragunovSniperRifle", new DragunovSniperRifle(shooting));
            weapons.Add("AC_VAL", new AC_VAL(shooting));
            weapons.Add("AK-47", new AK_47(shooting));
            weapons.Add("DT", new DT(shooting));
            weapons.Add("MaksimMachineGun", new MaksimMachineGun(shooting));
        }

        public Weapon GetWeapon(string name)
        {
            Weapon result;
            weapons.TryGetValue(name, out result);
            return result;
        }
    }
}

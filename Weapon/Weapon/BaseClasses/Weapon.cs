using System.Text.Json;

namespace Weapons
{
    public class Weapon : AbstrWeapon
    {
        public override string ItemType { get; }
        public override string Description { get; }
        protected static string pathJsonDescription { get; } = $"{Environment.CurrentDirectory}\\Descriptions.json"; //Json должен быть в папке исполняемого файла

        public override int Damage => 1; 
        public override float Caliber => -1f; //Значение зависит от TypePatron
        public override bool IsAutoRechargable => false;
        public override int MagazineSize => 1;
        public override TypePatron TypePatron => TypePatron.BasePatron;
        public override string DescriptionKey => throw new NotImplementedException();

        public Weapon(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }

        protected static string SetDescription(string pathJsonDescription, string descriptionKey)
        {
            string json = File.ReadAllText(pathJsonDescription);
            Dictionary<string, string> descriptions = JsonSerializer.Deserialize<Dictionary<string, string>>(json);

            return descriptions[descriptionKey];
        }
    }
}

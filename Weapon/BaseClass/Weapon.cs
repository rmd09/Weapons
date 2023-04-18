﻿using System.Text.Json;

namespace Weapons
{
    public class Weapon : AbstrWeapon
    {
        protected override string itemType { get; }
        protected override string description { get; }
        protected static string pathJsonDescription { get; } = $"{Environment.CurrentDirectory}\\Descriptions.json"; //Json должен быть в папке исполняемого файла

        public override int Damage => 1;
        public override bool IsAutoRechargable => false;
        public override int MagazineSize => 1;
        public override TypePatron TypePatron => TypePatron.BasePatron;

        public Weapon(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
            Information = new WeaponAndPatronInfo(GLOBAL_TYPE, itemType, description, TypePatron);
        }

        protected static string SetDescription(string pathJsonDescription, string descriptionKey)
        {
            string json = File.ReadAllText(pathJsonDescription);
            Dictionary<string, string> descriptions = JsonSerializer.Deserialize<Dictionary<string, string>>(json);

            return descriptions[descriptionKey];
        }
    }
}

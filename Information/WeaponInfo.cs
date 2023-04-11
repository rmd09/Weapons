namespace Weapons
{
    public class WeaponAndPatronInfo : Info
    {
        public float Caliber { get; private set; }
        public TypePatron TypePatron { get; private set; }

        public WeaponAndPatronInfo(GlobalType globalType, string itemType, string description, TypePatron typePatron) : base(globalType, itemType, description)
        {
            TypePatron = typePatron;
            Caliber = Patron.GetCaliberAndTypePatron(typePatron).Item1;
        }

        public override string ToString()
        {
            var CaliberAndTypePatron = Patron.GetCaliberAndTypePatron(TypePatron);

            return $"Инвентарь: {GlobalType}\nТип: {ItemType}\nОписание: {Description}\nТип патрона: {CaliberAndTypePatron.Item2}\nКалибр: {CaliberAndTypePatron.Item1}";
        }
    }
}

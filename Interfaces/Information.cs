namespace Weapons
{
    public class Info
    {
        public string GlobalType { get; private set; }
        public string ItemType { get; private set; }
        public string Description { get; private set; }

        public Info(string globalType)
        {
            GlobalType = globalType;
        }
        public Info(string globalType, string itemType, string description)
        {
            GlobalType = globalType;
            ItemType = itemType;
            Description = description;
        }

        public override string ToString()
        {
            return $"Инвентарь: {GlobalType}\nТип: {ItemType}\nОписание: {Description}";
        }
    }
}
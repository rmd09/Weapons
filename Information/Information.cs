namespace Weapons
{
    public class Info
    {
        public GlobalType GlobalType { get; private set; } 
        public string ItemType { get; private set; }
        public string Description { get; private set; }

        public Info(GlobalType globalType, string itemType, string description)
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
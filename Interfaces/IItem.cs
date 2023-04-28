namespace Weapons
{
    public interface IItem
    {
        GlobalType GlobalType { get; }
        string ItemType { get; }
        string Description { get; }
    }
}

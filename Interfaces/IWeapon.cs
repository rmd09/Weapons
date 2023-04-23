namespace Weapons
{
    public interface IWeapon : IItem
    {
        int Damage { get; }
        float Caliber { get; }
        bool IsAutoRechargable { get; }
        int MagazineSize { get; }
        int NumberOfPatrons { get; } //Кол-во патронов в данный момент
        TypePatron TypePatron { get; }

        void Shoot();
        void Recharge(); //Перезарядка
        void InsertMagazine(Magazine magazine);
        Magazine TakeMagazine();
    }
}

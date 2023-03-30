namespace Weapons
{
    public interface IWeapon : IItem
    {
        int Damage { get; }
        bool IsAutoRechargable { get; }
        int MagazineSize { get; }

        void Shoot();
        void Recharge();
        void InsertMagazine(Magazine magazine);
        Magazine TakeMagazine();
    }
}

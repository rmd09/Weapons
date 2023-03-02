namespace Weapons
{
    public interface IWeapon
    {
        int Damage { get; }
        bool IsAutoRechargable { get; }
        int MagazineSize { get; }
        static string Information { get; }

        void Shoot();
        void Recharge();
        void InsertMagazine(Magazine magazine);
        Magazine TakeMagazine();
    }
}

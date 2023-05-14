using System.Text.Json;

namespace Weapons
{
    public class GunMakarova : Gun
    {
        public override int Damage => base.Damage + 7;
        public override int MagazineSize => 8;
        public const string descriptionKey = "GunMakarova";
        public override string Description => SetDescription(pathJsonDescription, descriptionKey);

        public GunMakarova(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }
    }
}

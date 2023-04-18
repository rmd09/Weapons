using System.Text.Json;

namespace Weapons
{
    public class GunMakarova : Gun
    {
        public override int MagazineSize => 8;
        private const string descriptionKey = "GunMakarova";
        protected override string description => SetDescription(pathJsonDescription, descriptionKey);

        public GunMakarova(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }
    }
}

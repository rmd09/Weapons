using System.Text.Json;

namespace Weapons
{
    public class GunMakarova : Gun
    {
        private const string descriptionKey = "GunMakarova";
        protected override string description { get; } = SetDescription(pathJsonDescription, descriptionKey);

        public GunMakarova(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }
    }
}

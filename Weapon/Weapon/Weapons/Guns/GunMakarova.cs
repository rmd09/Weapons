using System.Text.Json;

namespace Weapons
{
    public class GunMakarova : Gun
    {
        public override int Damage => base.Damage + 7;
        public override int MagazineSize => 8;
        public override string DescriptionKey => "GunMakarova";
        public override string Name { get; } = "Пистолет Макарова";
        public override string Description => SetDescription(pathJsonDescription, DescriptionKey);

        public GunMakarova(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }
    }
}

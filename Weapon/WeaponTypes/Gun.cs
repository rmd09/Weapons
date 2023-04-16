﻿namespace Weapons
{
    public class Gun : Weapon
    {
        public override TypePatron TypePatron { get; } = TypePatron.GunPatron;
        protected override string itemType { get; } = "Пистолет";

        public Gun(EventHandler<ShootingArgs> shooting) : base(shooting)
        {
        }

    }
}
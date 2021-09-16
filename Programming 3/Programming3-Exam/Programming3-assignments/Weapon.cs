using System;
using System.Collections.Generic;
using System.Text;

namespace Programming3_assignments
{
    public enum WeaponType { Sword, Axe, Crossbow, Dagger };
    class Weapon : GameObject
    {
        public WeaponType type;

        public Weapon(int weight, WeaponType type)
            : base(weight)
        {
            this.type = type;
        }
    }
}

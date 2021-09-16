using System;

namespace assignment1
{
    //abstract base class
    public abstract class Character
    {
        //reference to strategy interface
        private IWeaponBehaviour weapon;
        //with this property the behaviour can be changed
        public IWeaponBehaviour Weapon
        {
            get { return weapon; }
            set { weapon = value; }
        }

        public Character()
        {
            //defafult
            weapon = new KnifeBehaviour();
        }

        public void Fight()
        {
            weapon.UseWeapon();
        }
    }
}

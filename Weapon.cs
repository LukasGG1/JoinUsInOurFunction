using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Weapon : Item
    {
        int _damage;
        Item longSword;
        Item dagger;
        Item bow;
        Item battleAxe;
        Item mace;
        Item _currentWeapon;
        private Item[] _inventory;


        public bool Contains(int itemIndex)
        {
            if (itemIndex > 0 && itemIndex < _inventory.Length)
            {
                return true;
            }
            return false;
        }

        public void EquipItem(int itemIndex)
        {
            if (Contains(itemIndex) == true)
            {
                _currentWeapon = _inventory[itemIndex];
            }
        }

        public Weapon(int damageVal)
        {
            _damage = damageVal;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Player : Character
    {
        //private string _name;
        //private int _health;
        //private int _damage;
        private Item[] _inventory;
        private Item currentWeapon;
        private Item hand;
        public Item statBoost;
        public Item currently;
        private int gold;



        public Player()
        {
            _inventory = new Item[3];
            gold = 100;
            health = 100;
            damage = 10;
            hand.name = "Kira's Fetish";
            hand.statBoost = 1;
        }
                            //S.H.I.E.L.D       0
        public Player(string nameVal, int healthVal, int damageVal, int inventorySize) : base(healthVal, nameVal, damageVal)
        {
            name = nameVal;
            health = healthVal;
            damage = damageVal;
            _inventory = new Item[inventorySize];
            hand.name = "Kira's Fetish";
            hand.statBoost = 1;
        }

        public bool Buy(Item item, int inventoryIndex)
        {   
            // Am I doing wrong?
            if(gold >= item.cost)
            {
                //pay for item
                gold -= item.cost;
                _inventory[inventoryIndex] = item;
                return true;
            }
            return false;
        }

        public int GetGold()
        {
            return gold;
        }

        public Item[] GetInventory()
        {
            return _inventory;
        }

        public void AddItemToInventory(Item item, int index)
        {
            _inventory[index] = item;
        }
        //I have no idea why it cannot apply indexing.
        public bool Contains(int itemIndex)
        {
            if (itemIndex > 0 && itemIndex < 4)
            {
                return true;
            }
            return false;
        }
            //89 year-old man
        public void EquipItem(int itemIndex)
        {
            if (Contains(itemIndex) == true)
            {
                currentWeapon = _inventory[itemIndex];
            }
        }


        public string GetName()
        {
            return name;
        }
        public bool GetIsAlive()
        {
            return health > 0;
        }

        public void UnequipItem()
        {
            currentWeapon = hand;
        }

        //public void Attack(Player enemy)
        //{
            //int totalDamage = damage + currentWeapon.statBoost;
            //enemy.TakeDamage(damage);  
        //}

        public void PrintStat()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Damage: " + damage);
        }

        public override float Attack(Character enemy)
        {
            float totalDamage = damage + currentWeapon.statBoost;
            enemy.TakeDamage(totalDamage);
            return totalDamage;
        }
        public void TakeDamage(int damageVal)
        {
            if(GetIsAlive())
            {
                health -= damageVal;
            }
            Console.WriteLine(name + " took " + damageVal + " damage!");
        }
        public int health;
        public int damage;
    }
}

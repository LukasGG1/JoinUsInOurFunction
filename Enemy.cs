using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Enemy
    {
        Random random = new Random();
        public string name = " ";
        public int damage;
        public int health;
        public int DodgeChance = 10;
        public int HitChance = 10;
        public string weakness = "None";
        Item currentWeapon;

        public bool GetIsAlive()
        {
            return health > 0;
        }
        Enemy(string nameVal, int healthVal, int damageVal)
        {
            name = nameVal;
            health = healthVal;
            damage = damageVal;
        }
        public Enemy()
        {
            void Attack(Enemy player)
            {
                int totalDamage = damage + currentWeapon.statBoost;
                player.TakeDamage(damage);
            }
        }
        private void TakeDamage(int damageVal)
        {
            if (GetIsAlive())
            {
                health -= damageVal;
            }
            Console.WriteLine(name + " took " + damageVal + " damage!");
        }
    }
}

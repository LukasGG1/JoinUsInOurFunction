using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Character
    {
        private float health;
        public string name;
        private float damage;

        public Character()
        {
            health = 100;
            name = "Newcomer";
            damage = 10;
        }
        public Character(float heatlhVal, string nameVal, float damageVal)
        {
            health = heatlhVal;
            name = nameVal;
            damage = damageVal;
        }

        public virtual float Attack(Character enemy)
        {
            float damageTaken = enemy.TakeDamage(damage);
           
            return damageTaken;
        }

        public virtual float TakeDamage(float damageVal)
        {
            health -= damageVal;
            if (health < -0)
            {
                health = 0;
            }
            return damageVal;
        }
    }
}

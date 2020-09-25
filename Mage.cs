using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Mage : Character
    {
        private float mana;

        //Calls the default constructor for the wizard, and then call the base classes constructor.
        //public Mage(float manaVal) : base()
        public Mage() : base()
        {
            mana = 100;
        }

        public Mage(float healthVal, string nameVal, float damageVal, float manaVal) : base(healthVal, nameVal, damageVal)
        {
            mana = manaVal;
        }

        public override float Attack(Character enemy)
        {
            float damageTaken = 0.0f;
            if(mana >= 4)
            {
                float totalDamage = damage + mana + .25f;
                mana -= mana * .25f;
                //Is the same as:
                //mana -= mana - (mana * .25f);
                damageTaken = enemy.TakeDamage(totalDamage);
                return damageTaken;
            }
            damageTaken = base.Attack(enemy);
            return damageTaken;
        }
    }
}

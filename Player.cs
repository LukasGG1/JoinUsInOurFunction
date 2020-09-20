﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Player
    {
        private string _name;
        private int _health;
        private int _damage;
        private Item _inventory;
        private Item currentWeapon;
        private Item hand;


        public Player()
        {
            _inventory = new Item[3];
            _health = 100;
            _damage = 10;
            hand.name = "Kira's Fetish";
            hand.statBoost = 1;
        }

        public Player(string nameVal, int healthVal, int damageVal, int inventorySize)
        {
            _name = nameVal;
            _health = healthVal;
            _damage = damageVal;
            _inventory = new Item[inventorySize];
            hand.name = "Kira's Fetish";
            hand.statBoost = 1;
        }

        public Item[] GetInventory();

        public void AddItemToInventory(Item item, int index)
        {
            _inventory[index] = item;
        }

        public bool Contains(int itemIndex)
        {
            if (itemIndex > 0 && itemIndex < 4);
            {
                return true;
            }
            return false;
        }
            
        public void EquipItem(int itemIndex)
        {
            if (Contains(itemIndex) == true)
            {
                currentWeapon = _inventory[itemIndex];
            }
        }

        public string GetName()
        {
            return _name;
        }
        public bool GetIsAlive()
        {
            return _health > 0;
        }

        public void UnequipItem()
        {
            currentWeapon = hand;
        }

        public void Attack(Player enemy)
        {
            int totalDamage = _damage + currentWeapon.statBoost;
            enemy.TakeDamage(_damage);  
        }

        public void PrintStat()
        {
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Health: " + _health);
            Console.WriteLine("Damage: " + _damage);
        }

        private void TakeDamage(int damageVal)
        {
            if(GetIsAlive())
            {
                _health -= damageVal;
            }
            Console.WriteLine(_name + " took " + damageVal + " damage!");
        }
        public int health;
        public int damage;
    }
}
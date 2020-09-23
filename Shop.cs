using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Shop : Item
    {
        private int gold;
        private Item[] _inventory;


        public Shop(Item[]item)
        {

        }

        public void CheckPlayerFunds(Player)
        {

        }

        public bool Sell(Player player, int shopIndex, int playerIndex)
        {
            return player.Buy(_inventory[shopIndex], playerIndex);
        }
    }
}

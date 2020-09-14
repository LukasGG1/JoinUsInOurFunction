using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    struct Player
    {
        public string name;
        public int health;
        public int damage;

    }
    struct Item
    {
        public int statBoost;
        public int RestoreHealth;
    }
    class Game
    {
        bool _gameOver = false;
        Player player1;
        Player player2;
        Item longSword;
        Item dagger;
        //Run the game
        public void Run()
        {
            Start();

            while (_gameOver == false) ;
            {
                Update();
            }
        
        End();
        }
    
        public void InitializePlayer()
        {
            //player1
            player1.health = 100;
            player1.damage = 5;
            //player2
            player2.health = 100;
            player2.damage = 5;
        }
        //Equip item to both players in the beginnning of the game
        public void GetInput(out char input, string option1, string option2, string query)
        {
            Console.WriteLine(query);
            Console.WriteLine("1. " + option1);
            Console.WriteLine("2. " + option2);
            Console.WriteLine("> ");
            //----------------------
            input = ' ';
            while(input != '1' && input != '2')
            {
                input = Console.ReadKey().KeyChar;
                if(input != '1' && input != '2')
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            //Weapon Choose
            //---------------------------------------

            input = Console.ReadKey().KeyChar;
        }

        public void EquipItem()
        {
            Console.WriteLine("Welcome to my blacksmith, newcomer! Please wisely choose a weapon might suit you.");
            Console.WriteLine("");
            Console.WriteLine("1. Long Sword");
            Console.WriteLine("2. Dagger");
            //Weapon Choose
            //---------------------------------------

            char input;
            GetInput(out input, "Longsword", "Dagger", "Welcome to my blacksmith, newcomer! Please wisely choose a weapon might suit you.");

            while(input != '1' && input != '2')
            {
                input = Console.ReadKey().KeyChar;
                if (input == '1')
                {
                    player1.damage += longSword.statBoost;
                }
                else if (input == '2')
                {
                    player1.damage += dagger.statBoost;
                }
            }
        }

        public void InitializeItem()
        {
            longSword.statBoost = 15;
            dagger.statBoost = 10;
        }
        //Performed once when the game begins
        public void Start()
        {
            InitializePlayer();
            InitializeItem();
        }

        //Repeated until the game ends
        public void Update()
        {
            
        }

        //Performed once when the game ends
        public void End()
        {
            
        }
    }
}

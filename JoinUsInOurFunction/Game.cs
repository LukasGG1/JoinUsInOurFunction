using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{

    struct Item
    {
        public int statBoost;
        public string name;
    }
    class Game
    {
        bool _gameOver = false;
        Player player1;
        Player player2;
        Item longSword;
        Item dagger;
        Item bow;
        Item battleAxe;
        Item mace;
        Item EightNineYearOldMan;
        //Run the game
        public void Run()
        {
            Start();

            while (_gameOver == false)
            {
                Update();
            }
        
        End();
        }
        //Equip item to both players in the beginnning of the game
        public void GetInput(out char input, string option1, string option2, string option3, string query)
        {
            //89 Year-old Man?
            Console.WriteLine(query);
            Console.WriteLine("1. " + option1);
            Console.WriteLine("2. " + option2);
            Console.WriteLine("3. " + option3);
            Console.WriteLine("> ");
            //----------------------
            input = ' ';
            while(input != '1' && input != '2' && input != '3')
            {
                input = Console.ReadKey().KeyChar;
                if(input != '1' && input != '2')
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            //89 Year-old Man is in bus! We need get him!
            //Weapon Choose
            //---------------------------------------
            //hELq
            input = Console.ReadKey().KeyChar;
        }

        public void SelectLoadout(Player player)
        {
            Console.Clear();
            Console.WriteLine("Loadout 1: ");
            Console.WriteLine(longSword.name);
            Console.WriteLine(bow.name);
            Console.WriteLine("\n Loadout 2: ");
            Console.WriteLine(battleAxe.name);
            Console.WriteLine(mace.name);
            Console.WriteLine(EightNineYearOldMan.name);
            //Weapon Choose
            //---------------------------------------
            //wHY ArE WE HeRE SuuffEriNg?
            char input;
            GetInput(out input, "Longsword", "Dagger", "Welcome to my blacksmith, newcomer 1! Please wisely choose a weapon might suit you.");
            //HAVE YOU SEEN 89 YEAR-OLD MAN?
            //HAVE YOU SEEN 89 YEAR-OLD MAN?
            //HAVE YOU SEEN 89 YEAR-OLD MAN?
            //HAVE YOU SEEN 89 YEAR-OLD MAN?
            //HAVE YOU SEEN 89 YEAR-OLD MAN?
            //HAVE YOU SEEN 89 YEAR-OLD MAN?
            //HAVE YOU SEEN 89 YEAR-OLD MAN?
            while (input != '1' && input != '2')
            {
                input = Console.ReadKey().KeyChar;
                if (input == '1')
                {
                    player.AddItemToInventory(longSword, 0);
                    player.AddItemToInventory(dagger, 1);
                    player.AddItemToInventory(bow, 2);
                }
                else if (input == '2')
                {
                    player.AddItemToInventory(battleAxe, 0);
                    player.AddItemToInventory(mace, 1);
                    player.AddItemToInventory(EightNineYearOldMan, 2);
                }
                Console.WriteLine("Player 1");
                player1.PrintStat();

                Console.Clear();

                GetInput(out input, "Longsword", "Dagger", "Welcome to my blacksmith, newcomer 2! Please wisely choose a weapon might suit you.");

                while (input != '1' && input != '2')
                {
                    input = Console.ReadKey().KeyChar;
                    if (input == '1')
                    {
                        player2.damage += longSword.statBoost;
                    }
                    else if (input == '2')
                    {
                        player2.damage += dagger.statBoost;
                    }
                    Console.WriteLine("Player 2");
                    player2.PrintStat();
                }
            }
        }

        public void CreateCharacter(Player player)
        {
            Console.WriteLine("What is your name, mortal?");
            string name = Console.ReadLine();
            player = new Player(name, 100, 10);
            SelectLoadout(player);
        }

        public void InitializeItem()
        {
            longSword.name = "Long Sword";
            longSword.statBoost = 15;
            dagger.name = "Dagger";
            dagger.statBoost = 10;
            bow.name = "Bow";
            bow.statBoost = 10;
            battleAxe.name = "Battle Axe";
            battleAxe.statBoost = 19;
            mace.name = "Mace";
            mace.statBoost = 17;
        }

        public void SwitchWeapon(Player player)
        {
            Item[] inventory = player.GetInventory();
            //Print all item to screen
            char input = ' ';
            for(int i = 0; i < 3; i++);
            {
                Console.WriteLine((i + 1) + ". " + inventory[i].name + "Damage: " + inventory[inventory].statBoost);
            }
            Console.Write("> ");
            input = Console.ReadKey().KeyChar;

            GetInput(out input, inventory[0].name, inventory[1], inventory[2].name, "Choose your weapon");


            switch(input)
            {
                case '1':
                    {
                        player.EquipItem(0);
                        Console.WriteLine("You equipped " + inventory[0].name);
                        Console.WriteLine("Damage increased by " + inventory[0].statBoost);
                        break;
                    }
                case '2':
                    {
                        player.EquipItem(1);
                        Console.WriteLine("You equipped " + inventory[1].name);
                        Console.WriteLine("Damage increased by " + inventory[1].statBoost);
                        break;
                    }
                case '3':
                    {
                        player.EquipItem(2);
                        Console.WriteLine("You equipped " + inventory[2].name);
                        Console.WriteLine("Damage increased by " + inventory[2].statBoost);
                        break;
                    }
                default:
                    {
                        player.UnequipItem();
                        Console.WriteLine("You are thinking about your voice and you acciently dropped weapon");

                        break;
                    }
            }
        }

        public void StartBattle()
        {
            Console.Clear();
            Console.WriteLine("Fight to death!");

            while (player1.GetIsAlive() && player2.GetIsAlive())
            {
                Console.WriteLine("Player 1");
                player1.PrintStat();
                Console.WriteLine("Player 2");
                player2.PrintStat();
                //Player 1 turn start
                char input;
                GetInput(out input, "Attack", "Change Weapon", "Your Turn, Player 1");

                if(input == '1')
                {

                    player2.Attack(player1);

                }
                else
                {
                    SwitchWeapon(player1);
                }

                
            }
            if (player1.GetIsAlive())
            {
                Console.WriteLine("Player 1 Won");
            }
            else
            {
                Console.WriteLine("Player 2 Won");
            }
            Console.Clear();
            _gameOver = true;
        }

        //Performed once when the game begins
        public void Start()
        {

            //InitializePlayer();
            InitializeItem();
        }

        //Repeated until the game ends
        public void Update()
        {
            CreateCharacter(player1);
            CreateCharacter(player2);
            SelectLoadout(player1);
            SelectLoadout(player2);
            StartBattle();
        }

        //Performed once when the game ends
        public void End()
        {
            
        }
    }
}

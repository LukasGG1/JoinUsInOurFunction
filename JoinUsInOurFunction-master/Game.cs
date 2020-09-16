using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{

    struct Item
    {
        public int statBoost;
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

            while (_gameOver == false)
            {
                Update();
            }
        
        End();
        }
        //Equip item to both players in the beginnning of the game
        public void GetInput(out char input, string option1, string option2, string query)
        {
            //89 Year-old Man?
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
            //89 Year-old Man is in bus! We need get him!
            //Weapon Choose
            //---------------------------------------
            //hELq
            input = Console.ReadKey().KeyChar;
        }

        public void EquipItem(Player player)
        {
            Console.WriteLine("Welcome to my blacksmith, newcomer! Please wisely choose a weapon might suit you.");
            Console.WriteLine("");
            Console.WriteLine("1. Long Sword");
            Console.WriteLine("2. Dagger");
            Console.WriteLine("3. 89 Year-Old Man");
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
                    player1.damage += longSword.statBoost;
                }
                else if (input == '2')
                {
                    player1.damage += dagger.statBoost;
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
            EquipItem(player);
        }

        public void InitializeItem()
        {
            longSword.statBoost = 15;
            dagger.statBoost = 10;
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
                GetInput(out input, "Attack", "No", "Your Turn, Player 1");

                if(input == '1')
                {

                    player2.Attack(player1);

                }
                else
                {
                    Console.WriteLine("None");
                }

                GetInput(out input, "Attack", "No", "Your Turn, Player 2");

                if (input == '1')
                {
                    player1.health -= player2.damage;
                    Console.WriteLine("Player 1 took " + player2.damage + " damage");

                }
                else
                {
                    Console.WriteLine("None");
                }
                Console.Clear();
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
            EquipItem(player1);
            EquipItem(player2);
            StartBattle();
        }

        //Performed once when the game ends
        public void End()
        {
            
        }
    }
}

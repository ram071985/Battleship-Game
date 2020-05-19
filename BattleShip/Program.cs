<<<<<<< HEAD
﻿using System;

namespace BattleShip
{
    class Program
    {
        static int shipRow;
        static int shipColumn;
        static int playerRow;
        static int playerColumn;
        static int roundNumber;
        static int battleshipHits;

            static void Main(string[] args)
        {
            StartGame();
            GenerateNewRound();
         
=======
﻿using System;

namespace BattleShip
{
    class Program
    {
        private static GameGrid _gameGrid;
        private static GameLogic _gameLogic;
        private static PlayerInput _playerInput;
>>>>>>> week-three
        

<<<<<<< HEAD


        public static void BattleshipPosition()
        {
            Random randomBattleshipRow = new Random();
            shipRow = randomBattleshipRow.Next(1, 11);
            Random randomBattleshipColumn = new Random();
            shipColumn = randomBattleshipColumn.Next(1, 11);
        }

        static void CalculateHit()
        {

           if (isGameOverDueToDepletedMissiles())
            {
                Console.WriteLine("Missiles Depleted");
                Console.WriteLine();
                Console.WriteLine("GAME OVER");
                Environment.Exit(0);
            } else if(isBattleshipHit())
            {
                battleshipHits += 1;
                Console.WriteLine(battleshipHits);
                Console.WriteLine("You've hit the battleship!");
                Console.WriteLine();
            
            } else if(isBattleshipHitWithFiveMissiles())
            {
                Console.WriteLine("CONGRATULATIONS! You've sunk the battleship!");
                Console.WriteLine();
                Console.WriteLine("You've Won The Game!");
            }
            else
            {
                Console.WriteLine("You missed the Battleship!");
            }
        }

        static bool isBattleshipHitWithFiveMissiles()
        {
            if (battleshipHits == 5)
            {
                return true;

                
            } else
            {
                return false;
            }
        }

        static bool isBattleshipHit()
        {
            if (playerRow == shipRow && playerColumn == shipColumn)
                return true;
            else
            {
                return false;
            }
        }

        static bool isGameOverDueToDepletedMissiles()
        {
            if (playerRow != shipRow && playerColumn != shipColumn && roundNumber == 9)
            {
                return true;
            } else

            {
                return false;
            }
=======
        static void Main(string[] args)
        {
            _gameGrid = new GameGrid();
            _playerInput = new PlayerInput();
            _gameLogic = new GameLogic(_gameGrid, _playerInput);
         
            StartGame();           
>>>>>>> week-three
        }

        public static void StartGame()
        {
            Console.WriteLine("Welcome to Battleship!");
            Console.WriteLine();
<<<<<<< HEAD
            Console.WriteLine("You get 8 attempts to fire at the battleship on the grid.  5 hits will sink the battleship.");
            Console.WriteLine();


        }

        static void GenerateNewRound()
        {
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Round " + i + " of 8");
                roundNumber = i;
                Console.WriteLine(roundNumber);
                ChooseRowNumber();
                ChooseColumnNumber();
                FireAtBattleShip();
                CalculateHit();
            }
        }


        public static void ChooseRowNumber()
=======
            Console.WriteLine("You have 8 attempts to fire at the battleship on the grid.  5 hits will sink the battleship.");
            Console.WriteLine();
            GenerateNewRound();

        }

        static void GenerateNewRound()
>>>>>>> week-three
        {
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Round " + i + " of 8");
                _gameLogic.roundNumber = i;
                var row = _playerInput.ReadPlayerRowInput();
                var column = _playerInput.ReadPlayerColumnInput();
                FireAtBattleShip();
                _gameLogic.CalculateHit(row, column);
                _gameLogic.PlayerIsWinner();
            }
        }

        private static void FireAtBattleShip()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("FIRE!");
            Console.WriteLine();


        }

<<<<<<< HEAD
=======


    }
>>>>>>> week-three


}

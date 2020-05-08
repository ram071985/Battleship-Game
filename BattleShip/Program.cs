using System;

namespace BattleShip
{
    class Program
    {
        public static int ROUNDNUMBER;
        private static GameGrid _gameGrid;
        private static GameLogic _gameLogic;
        private static PlayerInput _playerInput;
        

        static void Main(string[] args)
        {
            _gameGrid = new GameGrid();
            _playerInput = new PlayerInput();
            _gameLogic = new GameLogic(_gameGrid, _playerInput);
            StartGame();           
        }

        public static void StartGame()
        {
            _gameGrid.BattleshipRowPosition();
            _gameGrid.BattleshipColumnPosition();
            Console.WriteLine("Welcome to Battleship!");
            Console.WriteLine();
            Console.WriteLine("You have 8 attempts to fire at the battleship on the grid.  5 hits will sink the battleship.");
            Console.WriteLine();
            GenerateNewRound();

        }

        static void GenerateNewRound()
        {
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Round " + i + " of 8");
                ROUNDNUMBER = i;
                _playerInput.ReadPlayerRowInput();
                _playerInput.ReadPlayerColumnInput();
                FireAtBattleShip();
                _gameLogic.CalculateHit();
                _gameLogic.PlayerIsWinner();
            }
        }


        public static void ChooseRowNumberMessage()
        {
            Console.WriteLine("Choose a grid row number between 1 and 10");
        }

        public static void ChooseColumnNumberMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Choose a grid column number between 1 and 10");

        }

        private static void FireAtBattleShip()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("FIRE!");
            Console.WriteLine();


        }



    }


}

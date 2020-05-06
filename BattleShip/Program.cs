using System;

namespace BattleShip
{
    class Program
    {
        public static int roundNumber;

        static void Main(string[] args)
        {
            StartGame();
            GameLogic.TypeErrorHandling();


        }

        public static void StartGame()
        {
            GameGrid.BattleshipGridPosition();
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
                roundNumber = i;
                ChooseRowNumberMessage();
                PlayerInput.ReadPlayerRowInput();
                
                ChooseColumnNumberMessage();
                PlayerInput.ReadPlayerColumnInput();
                FireAtBattleShip();
                GameLogic.CalculateHit();
                GameLogic.PlayerIsWinner();
            }
        }


        public static void ChooseRowNumberMessage()
        {
            Console.WriteLine("Choose a grid row number between 1 and 10");
        }

        private static void ChooseColumnNumberMessage()
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

using System;
namespace BattleShip
{
    public class GameLogic
    {
        public int battleshipHits;
        private GameGrid _gameGrid;
        private PlayerInput _playerInput;
        public int roundNumber;

        public GameLogic(GameGrid gameGrid, PlayerInput playerInput)
        {
            _gameGrid = gameGrid;
            _playerInput = playerInput;
        }

        public void CalculateHit(int row, int column)
        {

            if (IsGameOverDueToDepletedMissiles())
            {
                Console.WriteLine("Missiles Depleted");
                Console.WriteLine();
                Console.WriteLine("GAME OVER");
                Environment.Exit(0);
            }
            else if (IsBattleshipHit(row, column))
            {
                battleshipHits += 1;
                int howManyHitsLeft = 5 - battleshipHits;
                Console.WriteLine("You've hit the battleship!");
                Console.WriteLine();
                Console.WriteLine("Battleship will sink in " + howManyHitsLeft + " more hits");
                
            }
            else if(IsBattleshipHit(row, column) == false)
            {
                Console.WriteLine("You missed the Battleship!");

            }
        }

        public void PlayerIsWinner()
        {
            if (IsBattleShipHitFiveTimes())
            {
                Console.WriteLine("CONGRATULATIONS! You've sunk the battleship!");
                Console.WriteLine();
                Console.WriteLine("You've Won The Game!");
                Environment.Exit(0);
            }
        }

        public bool IsBattleShipHitFiveTimes()
        {
            if (battleshipHits == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsBattleshipHit(int row, int column)
        {
            if (row == _gameGrid.BattleshipRow && column == _gameGrid.BattleshipColumn)
                return true;
            else
            {
                return false;
            }
        }

        public bool IsGameOverDueToDepletedMissiles()
        {
            if (roundNumber == 8)
            {
                return true;
            }
            else

            {
                return false;
            }
        }
    }
}

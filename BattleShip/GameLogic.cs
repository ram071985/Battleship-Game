using System;
namespace BattleShip
{
    public class GameLogic
    {
        public int battleshipHits;
        private GameGrid _gameGrid;
        private GameMessageService _gameMessageService;
        public int roundNumber;

        public GameLogic(GameGrid gameGrid, GameMessageService gameMessageService)
        {
            _gameGrid = gameGrid;
            _gameMessageService = gameMessageService;
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
            if (row == _gameGrid.battleshipRow && column == _gameGrid.battleshipColumn)
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

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
            return battleshipHits == 5;
           
        }

        public bool IsBattleshipHit(int row, int column)
        {
            return row == _gameGrid.battleshipRow && column == _gameGrid.battleshipColumn;
        }

        public bool IsGameOverDueToDepletedMissiles()
        {
            return roundNumber == 8;
           
        }
    }
}

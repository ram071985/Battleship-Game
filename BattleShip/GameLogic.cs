using System;
namespace BattleShip
{
    public class GameLogic
    {
        public int BATTLESHIPHITS;
        private GameGrid _gameGrid;
        private PlayerInput _playerInput;

        public GameLogic(GameGrid gameGrid, PlayerInput playerInput)
        {
            _gameGrid = gameGrid;
            _playerInput = playerInput;
        }

        public void CalculateHit()
        {

            if (IsGameOverDueToDepletedMissiles())
            {
                Console.WriteLine("Missiles Depleted");
                Console.WriteLine();
                Console.WriteLine("GAME OVER");
                Environment.Exit(0);
            }
            else if (IsBattleshipHit())
            {
                BATTLESHIPHITS += 1;
                int howManyHitsLeft = 5 - BATTLESHIPHITS;
                Console.WriteLine("You've hit the battleship!");
                Console.WriteLine();
                Console.WriteLine("Battleship will sink in " + howManyHitsLeft + " more hits");
                _gameGrid.BattleshipRowPosition();
                _gameGrid.BattleshipColumnPosition();
            }
            else if(IsBattleshipHit() == false)
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
            if (BATTLESHIPHITS == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsBattleshipHit()
        {
            if (_playerInput.ReadPlayerRowInput() == _gameGrid.BattleshipRowPosition() && _playerInput.ReadPlayerColumnInput() == _gameGrid.BattleshipColumnPosition())
                return true;
            else
            {
                return false;
            }
        }

        public bool IsGameOverDueToDepletedMissiles()
        {
            if (Program.ROUNDNUMBER == 8)
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

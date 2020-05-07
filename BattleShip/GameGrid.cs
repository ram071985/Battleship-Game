using System;
namespace BattleShip
{
    public class _gameGrid
    {
        public int shipRow;
        public int shipColumn;

        public void BattleshipGridPosition()
        {
            Random randomBattleshipRow = new Random();
            shipRow = randomBattleshipRow.Next(1, 11);
            Random randomBattleshipColumn = new Random();
            shipColumn = randomBattleshipColumn.Next(1, 11);
        }
    }
}

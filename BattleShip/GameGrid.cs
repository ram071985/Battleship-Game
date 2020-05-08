using System;
namespace BattleShip
{
    public class GameGrid
    {
        public int BattleshipRowPosition()
        {
            Random randomBattleshipRow = new Random();
            var shipRow = randomBattleshipRow.Next(1, 11);
            return shipRow;
        }

        public int BattleshipColumnPosition()
        {
            Random randomBattleshipColumn = new Random();
            var shipColumn = randomBattleshipColumn.Next(1, 11);
            return shipColumn;
        }
    }
}

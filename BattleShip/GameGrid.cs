using System;
namespace BattleShip
{
    public class GameLogic
    {
        public int shipRow;
        public int shipColumn;

        public void BattleShipGridPosition()
        {
            Random randomBattleshipRow = new Random();
            shipRow = randomBattleshipRow.Next(1, 11);
            Random randomBattleshipColumn = new Random();
            shipColumn = randomBattleshipColumn.Next(1, 11);
        }
    }
}

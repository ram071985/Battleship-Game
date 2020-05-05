using System;
namespace BattleShip
{
    public class GameGrid
    {
        public static int shipRow;
        public static int shipColumn;

        public static void BattleshipGridPosition()
        {
            Random randomBattleshipRow = new Random();
            shipRow = randomBattleshipRow.Next(1, 11);
            Random randomBattleshipColumn = new Random();
            shipColumn = randomBattleshipColumn.Next(1, 11);
        }
    }
}

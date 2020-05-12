using System;
namespace BattleShip
{
    public class GameGrid
    {
        public int BattleshipRow {get; set; }
        public int BattleshipColumn {get; set; }
        public GameGrid()
        {
            var randomBattleshipRow = new Random();
            BattleshipRow = randomBattleshipRow.Next(1, 11);
            var randomBattleshipColumn = new Random();
            BattleshipColumn = randomBattleshipColumn.Next(1, 11);
        }
    }
}

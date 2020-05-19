using System;
namespace BattleShip
{
    public class GameGrid
    {
        public int battleshipRow {get; set; }
        public int battleshipColumn {get; set; }
        public GameGrid()
        {
            var randomBattleshipRow = new Random();
            battleshipRow = randomBattleshipRow.Next(1, 11);
            battleshipColumn = randomBattleshipRow.Next(1, 11);
        }
    }
}

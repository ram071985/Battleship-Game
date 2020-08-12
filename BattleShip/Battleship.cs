using System;
namespace BattleShip
{
    public class Battleship
    {
        public int Row {get; private set; }
        public int Column {get; private set; }
        public int Hits { get; private set; }

        public Battleship()
        {
            ResetPosition();
        }

        public bool ShootMissile(int row, int column)
        {           
            var isHit = row == Row && column == Column;
            if (isHit)
            {
                Hits++;
            }
            
            return isHit;
        }

        public bool IsSunk(int hits)
        {
            return Hits >= 5;
        }

        public void ResetPosition()
        {
            var randomBattleshipRow = new Random();
            Row = randomBattleshipRow.Next(1, 11);
            Column = randomBattleshipRow.Next(1, 11);
        }
    }
}

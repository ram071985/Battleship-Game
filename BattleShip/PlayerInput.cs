using System;
namespace BattleShip
{
    public class PlayerInput
    {
        public int playerRow;
        public int playerColumn;

        public void ReadPlayerInput()
        {
            playerRow = Convert.ToInt32(Console.ReadLine());
            playerColumn = Convert.ToInt32(Console.ReadLine());
        }
    }
}

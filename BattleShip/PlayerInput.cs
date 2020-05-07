using System;
namespace BattleShip
{
    public class PlayerInput
    {
        public int playerRow;
        public int playerColumn;

        public void ReadPlayerRowInput()
        {
            playerRow = Convert.ToInt32(Console.ReadLine());
        }

        public void ReadPlayerColumnInput()
        {
           playerColumn = Convert.ToInt32(Console.ReadLine());
        } 
    }
}

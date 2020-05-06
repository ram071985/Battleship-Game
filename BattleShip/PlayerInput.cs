using System;
namespace BattleShip
{
    public class PlayerInput
    {
        public static int playerRow;
        public static int playerColumn;

        public static void ReadPlayerRowInput()
        {
            playerRow = Convert.ToInt32(Console.ReadLine());
        }

        public static void ReadPlayerColumnInput()
        {
           playerColumn = Convert.ToInt32(Console.ReadLine());
        }
    }
}

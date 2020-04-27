using System;
namespace BattleShip
{
    public class BattleShipLogic 
    {
        public static void BattleShipRowNumber()
        {
            Random randomRow = new Random();
            Random randomColumn = new Random();
          
        }

        public static void BattleShipColumnNumber()
        {
            Random random = new Random();
            Console.WriteLine(random.Next(1, 11));
        }
    }
}

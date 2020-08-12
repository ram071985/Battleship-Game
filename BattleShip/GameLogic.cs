using System;
namespace BattleShip
{
    public class GameLogic
    {
        public int roundNumber;

        public bool IsGameOverDueToDepletedMissiles()
        {
            return roundNumber == 8;
           
        }
    }
}

using System;
namespace BattleShip
{
    public class GameLogic
    {
        public int roundNumber;
        public int battleshipHits;


        public static void CalculateHit()
        {

            if (IsGameOverDueToDepletedMissiles())
            {
                Console.WriteLine("Missiles Depleted");
                Console.WriteLine();
                Console.WriteLine("GAME OVER");
                Environment.Exit(0);
            }
            else if (IsBattleshipHit())
            {
                battleshipHits += 1;
                Console.WriteLine("You've hit the battleship!");
                Console.WriteLine();
                BattleshipPosition();


            }
            else
            {
                Console.WriteLine("You missed the Battleship!");

            }
        }

        public static void PlayerIsWinner()
        {
            if (IsBattleShipHitFiveTimes())
            {
                Console.WriteLine("CONGRATULATIONS! You've sunk the battleship!");
                Console.WriteLine();
                Console.WriteLine("You've Won The Game!");
                Environment.Exit(0);
            }
        }

        public static bool IsBattleShipHitFiveTimes()
        {
            if (battleshipHits == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DidPlayerMissBattleship()
        {
            if (playerRow != shipRow && playerColumn != shipColumn)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsBattleshipHit()
        {
            if (playerRow == shipRow && playerColumn == shipColumn)
                return true;
            else
            {
                return false;
            }
        }

        public static bool IsGameOverDueToDepletedMissiles()
        {
            if (roundNumber == 8)
            {
                return true;
            }
            else

            {
                return false;
            }
        }
    }
}

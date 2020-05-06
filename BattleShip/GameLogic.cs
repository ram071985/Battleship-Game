﻿using System;
namespace BattleShip
{
    public class GameLogic
    {
        public static int battleshipHits;


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
                int howManyHitsLeft = 5 - battleshipHits;
                Console.WriteLine("You've hit the battleship!");
                Console.WriteLine();
                Console.WriteLine("Battleship will sink in " + howManyHitsLeft + " more hits");
                GameGrid.BattleshipGridPosition();



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
            if (PlayerInput.playerRow != GameGrid.shipRow && PlayerInput.playerColumn != GameGrid.shipColumn)
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
            if (PlayerInput.playerRow == GameGrid.shipRow && PlayerInput.playerColumn == GameGrid.shipColumn)
                return true;
            else
            {
                return false;
            }
        }

        public static bool IsGameOverDueToDepletedMissiles()
        {
            if (Program.roundNumber == 8)
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
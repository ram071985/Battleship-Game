using System;

namespace BattleShip
{
    class Program
    {
        static int shipRow = 3;
        static int shipColumn = 3;
        static int playerRow;
        static int playerColumn;
        static int roundNumber;
        static int battleshipHits;

        static void Main(string[] args)
        {
            StartGame();
            GenerateNewRound();


        }



        public static void BattleshipPosition()
        {
            Random randomBattleshipRow = new Random();
            shipRow = randomBattleshipRow.Next(1, 11);
            Random randomBattleshipColumn = new Random();
            shipColumn = randomBattleshipColumn.Next(1, 11);
        }

        static void CalculateHit()
        {

            if (isGameOverDueToDepletedMissiles())
            {
                Console.WriteLine("Missiles Depleted");
                Console.WriteLine();
                Console.WriteLine("GAME OVER");
                Environment.Exit(0);
            }
            else if (isBattleshipHit())
            {
                battleshipHits += 1;
                Console.WriteLine(battleshipHits);
                Console.WriteLine("You've hit the battleship!");
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine("You missed the Battleship!");
            }
        }

        static void PlayerIsWinner()
        {
             if (isBattleShipHitFiveTimes())
            {
                Console.WriteLine("CONGRATULATIONS! You've sunk the battleship!");
                Console.WriteLine();
                Console.WriteLine("You've Won The Game!");
                Environment.Exit(0);
            }
        }

        static bool isBattleShipHitFiveTimes()
        {
            if(battleshipHits == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool isBattleshipHit()
        {
            if (playerRow == shipRow && playerColumn == shipColumn)
                return true;
            else
            {
                return false;
            }
        }

        static bool isGameOverDueToDepletedMissiles()
        {
            if (playerRow != shipRow && playerColumn != shipColumn && roundNumber == 9)
            {
                return true;
            }
            else

            {
                return false;
            }
        }

        public static void StartGame()
        {
            Console.WriteLine("Welcome to Battleship!");
            Console.WriteLine();
            Console.WriteLine("You get 8 attempts to fire at the battleship on the grid.  5 hits will sink the battleship.");
            Console.WriteLine();


        }

        static void GenerateNewRound()
        {
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Round " + i + " of 8");
                roundNumber = i;
                Console.WriteLine(roundNumber);
                ChooseRowNumber();
                ChooseColumnNumber();
                FireAtBattleShip();
                CalculateHit();
                PlayerIsWinner();
            }
        }


        public static void ChooseRowNumber()
        {
            Console.WriteLine("Choose a grid row number between 1 and 10");
            playerRow = Convert.ToInt32(Console.ReadLine());
        }

        private static void ChooseColumnNumber()
        {
            Console.WriteLine();
            Console.WriteLine("Choose a grid column number between 1 and 10");
            playerColumn = Convert.ToInt32(Console.ReadLine());

        }

        private static void FireAtBattleShip()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("FIRE!");
            Console.WriteLine();


        }



    }


}

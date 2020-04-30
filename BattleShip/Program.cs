using System;

namespace BattleShip
{
    class Program
    {

        static int shipRow;
        static int shipColumn;
        static int playerRow;
        static int playerColumn;
        static bool roundEight;

            static void Main(string[] args)
        {
            StartGame();
            RoundOne();
            RoundTwo();
            RoundThree();
            RoundFour();
            RoundFive();
            RoundSix();
            RoundSeven();
            RoundEight();
        
        }

        static void CalculateHit()
        {

            if (playerRow != shipRow && playerColumn != shipColumn)
            {

                Console.WriteLine("You missed the Battleship!");
            }
            else if (playerRow != shipRow && playerColumn != shipColumn && roundEight == true)
            {
                Console.WriteLine("You missed the Battleship!");
                Console.WriteLine();
                Console.WriteLine("GAME OVER");
                Environment.Exit(0);
            }
            else
            { 

                Console.WriteLine("You've sunk the battleship!");
                Console.WriteLine();
                Console.WriteLine("Congratulations!");
                Environment.Exit(0);
            }
        }

        public static void StartGame()
        {
            roundEight = false;
            BattleShipLogic();
            Console.WriteLine("Welcome to Battleship!");
            Console.WriteLine();
            Console.WriteLine("You get 8 attempts to fire at the battleship on the grid");
            Console.WriteLine();


        }
        static void BattleShipLogic()
        {
            Random randomBattleshipRow = new Random();
            shipRow = randomBattleshipRow.Next(1, 11);
            Random randomBattleshipColumn = new Random();
            shipColumn = randomBattleshipColumn.Next(1, 11);
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

        static void RoundOne()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Round 1 of 8");
            ChooseRowNumber();
            ChooseColumnNumber();
            FireAtBattleShip();
            CalculateHit();
           
        }

        static void RoundTwo()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Round 2 of 8");
            ChooseRowNumber();
            ChooseColumnNumber();
            FireAtBattleShip();
            CalculateHit();

        }

        static void RoundThree()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Round 3 of 8");
            ChooseRowNumber();
            ChooseColumnNumber();
            FireAtBattleShip();
            CalculateHit();

        }

        static void RoundFour()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Round 4 of 8");
            ChooseRowNumber();
            ChooseColumnNumber();
            FireAtBattleShip();
            CalculateHit();

        }

        static void RoundFive()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Round 5 of 8");
            ChooseRowNumber();
            ChooseColumnNumber();
            FireAtBattleShip();
            CalculateHit();

        }

        static void RoundSix()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Round 6 of 8");
            ChooseRowNumber();
            ChooseColumnNumber();
            FireAtBattleShip();
            CalculateHit();

        }


        private static void RoundSeven()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Round 7 of 8");
            ChooseRowNumber();
            ChooseColumnNumber();
            FireAtBattleShip();
            CalculateHit();

        }

        private static void RoundEight()
        {
            roundEight = true;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Round 8 of 8");
            ChooseRowNumber();
            ChooseColumnNumber();
            FireAtBattleShip();
            CalculateHit();


        }


    }

  
}

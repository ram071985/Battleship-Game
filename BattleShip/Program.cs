using System;

namespace BattleShip
{
    class Program
    {
        static void Main(string[] args)
        {
            StartGame();

            ChooseRowNumber();
            int playerRow = Convert.ToInt32(Console.ReadLine());

            ChooseColumnNumber();
            int playerColumn = Convert.ToInt32(Console.ReadLine());

            FireAtBattleShip();

            Random randomBattleshipRow = new Random();
            int shipRow = randomBattleshipRow.Next(1, 11);
            Random randomBattleshipColumn = new Random();
            int shipColumn = randomBattleshipColumn.Next(1, 11);

            if (playerRow == shipRow && playerColumn == shipColumn)
            {
                Console.WriteLine("You've sunk the battleship!");
                Console.WriteLine();
                Console.WriteLine("Congratulations!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("You missed the Battleship!");

            }

            RoundTwo();
            Console.WriteLine();
            ChooseRowNumber();
            int playerRowTwo = Convert.ToInt32(Console.ReadLine());

            ChooseColumnNumber();
            int playerColumnTwo = Convert.ToInt32(Console.ReadLine());
            FireAtBattleShip();

            Random randomBattleshipRowTwo = new Random();
            int shipRowTwo = randomBattleshipRowTwo.Next(1, 11);
            Random randomBattleshipColumnTwo = new Random();
            int shipColumnTwo = randomBattleshipColumnTwo.Next(1, 11);
            if (playerRowTwo == shipRowTwo && playerColumnTwo == shipColumnTwo)
            {
                Console.WriteLine("You've sunk the battleship!");
                Console.WriteLine();
                Console.WriteLine("Congratulations!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("You missed the Battleship!");
            }

            RoundThree();
            Console.WriteLine();
            ChooseRowNumber();
            int playerRowThree = Convert.ToInt32(Console.ReadLine());

            ChooseColumnNumber();
            int playerColumnThree = Convert.ToInt32(Console.ReadLine());
            FireAtBattleShip();

            Random randomBattleshipRowThree = new Random();
            int shipRowThree = randomBattleshipRowThree.Next(1, 11);
            Random randomBattleshipColumnThree = new Random();
            int shipColumnThree = randomBattleshipColumnThree.Next(1, 11);
            if (playerRowThree== shipRowThree && playerColumnThree == shipColumnThree)
            {
                Console.WriteLine("You've sunk the battleship!");
                Console.WriteLine();
                Console.WriteLine("Congratulations!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("You missed the Battleship!");
            }

            RoundFour();
            Console.WriteLine();
            ChooseRowNumber();
            int playerRowFour = Convert.ToInt32(Console.ReadLine());

            ChooseColumnNumber();
            int playerColumnFour = Convert.ToInt32(Console.ReadLine());
            FireAtBattleShip();

            Random randomBattleshipRowFour = new Random();
            int shipRowFour = randomBattleshipRowFour.Next(1, 11);
            Random randomBattleshipColumnFour = new Random();
            int shipColumnFour = randomBattleshipColumnFour.Next(1, 11);
            if (playerRowFour == shipRowFour && playerColumnFour == shipColumnFour)
            {
                Console.WriteLine("You've sunk the battleship!");
                Console.WriteLine();
                Console.WriteLine("Congratulations!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("You missed the Battleship!");
            }

            RoundFive();
            Console.WriteLine();
            ChooseRowNumber();
            int playerRowFive = Convert.ToInt32(Console.ReadLine());

            ChooseColumnNumber();
            int playerColumnFive = Convert.ToInt32(Console.ReadLine());
            FireAtBattleShip();

            Random randomBattleshipRowFive = new Random();
            int shipRowFive = randomBattleshipRowFive.Next(1, 11);
            Random randomBattleshipColumnFive = new Random();
            int shipColumnFive = randomBattleshipColumnFive.Next(1, 11);
            if (playerRowFive == shipRowFive && playerColumnFive == shipColumnFive)
            {
                Console.WriteLine("You've sunk the battleship!");
                Console.WriteLine();
                Console.WriteLine("Congratulations!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("You missed the Battleship!");
            }

            RoundSix();
            Console.WriteLine();
            ChooseRowNumber();
            int playerRowSix = Convert.ToInt32(Console.ReadLine());

            ChooseColumnNumber();
            int playerColumnSix = Convert.ToInt32(Console.ReadLine());
            FireAtBattleShip();

            Random randomBattleshipRowSix = new Random();
            int shipRowSix = randomBattleshipRowSix.Next(1, 11);
            Random randomBattleshipColumnSix = new Random();
            int shipColumnSix= randomBattleshipColumnSix.Next(1, 11);
            if (playerRowSix == shipRowSix && playerColumnSix == shipColumnSix)
            {
                Console.WriteLine("You've sunk the battleship!");
                Console.WriteLine();
                Console.WriteLine("Congratulations!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("You missed the Battleship!");
            }

            RoundSeven();
            Console.WriteLine();
            ChooseRowNumber();
            int playerRowSeven = Convert.ToInt32(Console.ReadLine());

            ChooseColumnNumber();
            int playerColumnSeven = Convert.ToInt32(Console.ReadLine());
            FireAtBattleShip();

            Random randomBattleshipRowSeven = new Random();
            int shipRowSeven = randomBattleshipRowSeven.Next(1, 11);
            Random randomBattleshipColumnSeven = new Random();
            int shipColumnSeven = randomBattleshipColumnSeven.Next(1, 11);
            if (playerRowSeven == shipRowSeven && playerColumnSeven == shipColumnSeven)
            {
                Console.WriteLine("You've sunk the battleship!");
                Console.WriteLine();
                Console.WriteLine("Congratulations!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("You missed the Battleship!");
            }

            RoundEight();
            Console.WriteLine();
            ChooseRowNumber();
            int playerRowEight = Convert.ToInt32(Console.ReadLine());

            ChooseColumnNumber();
            int playerColumnEight = Convert.ToInt32(Console.ReadLine());
            FireAtBattleShip();

            Random randomBattleshipRowEight = new Random();
            int shipRowEight = randomBattleshipRowEight.Next(1, 11);
            Random randomBattleshipColumnEight = new Random();
            int shipColumnEight = randomBattleshipColumnEight.Next(1, 11);
            if (playerRowEight == shipRowEight && playerColumnEight == shipColumnEight)
            {
                Console.WriteLine("You've sunk the battleship!");
                Console.WriteLine();
                Console.WriteLine("Congratulations!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("You missed the Battleship!");
                Console.WriteLine();
                Console.WriteLine("GAME OVER");
            }


        }

        public static void StartGame()
        {
            Console.WriteLine("Welcome to Battleship!");
            Console.WriteLine();
            Console.WriteLine("You get 8 attempts to fire at the battleship on the grid");
            Console.WriteLine();
            Console.WriteLine("Round 1 of 8");
            Console.WriteLine();


        }

        public static void ChooseRowNumber()
        {
            Console.WriteLine("Choose a grid row number between 1 and 10");
        }   

        private static void ChooseColumnNumber()
        {
            Console.WriteLine();
            Console.WriteLine("Choose a grid column number between 1 and 10");
           
        }

        private static void FireAtBattleShip()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("FIRE!");
            Console.WriteLine();


        }

        private static void RoundTwo()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Round 2 of 8");
        }

        private static void RoundThree()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Round 3 of 8");
        
        }

        private static void RoundFour()
            {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Round 4 of 8");
           
        }

        private static void RoundFive()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Round 5 of 8");
          
        }

        private static void RoundSix()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Round 6 of 8");
         
        }

        private static void RoundSeven()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Round 7 of 8");
          
        }

        private static void RoundEight()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Round 8 of 8");
    

        }


    }

  
}

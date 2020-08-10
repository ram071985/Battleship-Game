using System;
namespace BattleShip
{
    public class GameMessageService
    {
        public void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to Battleship!");
            Console.WriteLine();
            Console.WriteLine("You have 8 attempts to fire at the battleship on the grid.  5 hits will sink the battleship.");
            Console.WriteLine();
        }

        public void DisplayRoundNumber(int roundNumber)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Round " + roundNumber + " of 8");
        }

        public void DisplayMissileFireMessage()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("FIRE!");
            Console.WriteLine();
        }

        public int ReadPlayerRowInput()
        {
            Console.WriteLine("Choose a grid row number between 1 and 10");
            var isNumber = int.TryParse(Console.ReadLine(), out int userInput);
            if (userInput < 1 || userInput > 10 || isNumber == false)
                while (isNumber == false)
                {
                    Console.WriteLine("INVALID ENTRY!");
                    Console.WriteLine("PLEASE ENTER A VALID NUMBER 1-10");
                    isNumber = int.TryParse(Console.ReadLine(), out userInput);
                }
            return userInput;
        }

        public int ReadPlayerColumnInput()
        {
            Console.WriteLine("Choose a grid column number between 1 and 10");
            var isNumber = int.TryParse(Console.ReadLine(), out int userInput);
            if (userInput < 1 || userInput > 10 || isNumber == false)
                while (isNumber == false)
                {
                    Console.WriteLine("INVALID ENTRY!");
                    Console.WriteLine("PLEASE ENTER A VALID NUMBER 1-10");
                    isNumber = int.TryParse(Console.ReadLine(), out userInput);
                }
            return userInput;
        }
    }
}

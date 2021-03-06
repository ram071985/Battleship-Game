﻿using System;
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

        public void DisplayGameOverMessage()
        {
            Console.WriteLine("Missiles Depleted");
            Console.WriteLine();
            Console.WriteLine("GAME OVER");
            Environment.Exit(0);
        }

        public void DisplayMissedMissileMessage()
        {
            Console.WriteLine("You missed the Battleship!");
        }

        public void DisplayMissileHitMessage(int howManyHitsLeft)
        {
            Console.WriteLine("You've hit the battleship!");
            Console.WriteLine();
            Console.WriteLine("Battleship will sink in " + howManyHitsLeft + " more hits");
        }

        public void DisplayWinnerMessage()
        {
            Console.WriteLine("CONGRATULATIONS! You've sunk the battleship!");
            Console.WriteLine();
            Console.WriteLine("You've Won The Game!");
            Environment.Exit(0);
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

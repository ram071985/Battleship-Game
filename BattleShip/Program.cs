﻿using System;

namespace BattleShip
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameGrid = new GameGrid();
            var gameMessageService = new GameMessageService();
            var gameLogic = new GameLogic(gameGrid, gameMessageService);

            gameMessageService.DisplayWelcomeMessage();

            for (int i = 1; i < 9; i++)
            {
                gameMessageService.DisplayRoundNumber(i);
                gameLogic.roundNumber = i;
                var row = gameMessageService.ReadPlayerRowInput();
                var column = gameMessageService.ReadPlayerColumnInput();
                gameLogic.CalculateHit(row, column);
                gameLogic.PlayerIsWinner();
            }
        }
    }
}

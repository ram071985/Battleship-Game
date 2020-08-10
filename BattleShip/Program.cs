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
                
                if (gameLogic.IsGameOverDueToDepletedMissiles())
                {
                    gameMessageService.DisplayGameOverMessage();
                }
                else if (gameLogic.IsBattleshipHit(row, column))
                {
                    gameLogic.battleshipHits += 1;        
                    gameMessageService.DisplayMissileHitMessage(5 - gameLogic.battleshipHits);
                    gameGrid = new GameGrid();

                }
                else if (gameLogic.IsBattleshipHit(row, column) == false)
                {

                    gameMessageService.DisplayMissedMissileMessage();
                }
                gameLogic.PlayerIsWinner();
            }
        }
    }
}

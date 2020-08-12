﻿using System;

namespace BattleShip
{
    class Program
    {
        static void Main(string[] args)
        {
            var battleship = new Battleship();
            var gameMessageService = new GameMessageService();
            var gameLogic = new GameLogic();

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

                var battleShipIsHit = battleship.ShootMissile(row, column);

                if (battleShipIsHit == true)
                {    
                    gameMessageService.DisplayMissileHitMessage(5 - battleship.Hits);
                    battleship.ResetPosition();
                }
                else
                {
                    gameMessageService.DisplayMissedMissileMessage();
                }
                if(battleship.IsSunk() == true)
                {
                    gameMessageService.DisplayWinnerMessage();
                }
            }
        }
    }
}

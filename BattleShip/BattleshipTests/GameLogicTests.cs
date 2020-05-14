using System;
using BattleShip;

namespace BattleshipTests
{
    public class GameLogicTests
    {
        private GameLogic _gameLogic;

        public void Setup()
        {
            var gameGrid = new GameGrid();
            var playerInput = new PlayerInput();

            _gameLogic = new GameLogic(gameGrid, playerInput);
        }

        public void should_is_game_over_due_to_depleted_missiles_return_true()
        {

        }
    }
}

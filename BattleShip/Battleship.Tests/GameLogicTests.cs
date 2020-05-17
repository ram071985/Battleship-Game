using System;
using BattleShip;
using NUnit.Framework;

namespace BattleshipTests
{
    [TestFixture]
    public class GameLogicTests
    {
        private GameLogic _gameLogic;

        public void Setup()
        {
            var gameGrid = new GameGrid();
            var playerInput = new PlayerInput();

            _gameLogic = new GameLogic(gameGrid, playerInput);
        }

        [Test]
        public void should_is_game_over_due_to_depleted_missiles_return_true()
        {
            _gameLogic.roundNumber = 8;
            var result = _gameLogic.IsGameOverDueToDepletedMissiles();
            Assert.IsTrue(result);
        }

        [Test]
        public void should_is_game_over_due_to_depleted_missiles_return_false()
        {
            _gameLogic.roundNumber = 0;
            var result = _gameLogic.IsGameOverDueToDepletedMissiles();
            Assert.IsFalse(result);
        }
    }
}
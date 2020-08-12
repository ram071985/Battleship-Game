using System;
using BattleShip;
using NUnit.Framework;

namespace Battleship.Tests
{
    [TestFixture]
    public class GameLogicTests
    {
        private GameLogic _gameLogic;

        public void Setup()
        {
            var gameGrid = new BattleShip.Battleship();

            _gameLogic = new GameLogic();
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
            _gameLogic = new GameLogic();

            _gameLogic.roundNumber = 0;
            var result = _gameLogic.IsGameOverDueToDepletedMissiles();
            Assert.IsFalse(result);
        }
    }
}
using System;
using BattleShip;
using NUnit.Framework;

namespace Battleship.Tests
{
    [TestFixture]
    public class BattleshipGridTest
    {
        private GameGrid _gameGrid;

        public void Setup()
        {
            _gameGrid = new GameGrid();
          
        }

        [Test]
        public void should_battleship_row_is_equal_to_number_one_through_ten_is_true()
        {
            _gameGrid = new GameGrid();
            Assert.IsTrue(_gameGrid, GreaterThan(0));
            Assert.IsTrue(_gameGrid, LessThan(11));
        }

        [Test]
        public void should_battleship_row_is_equal_to_number_one_through_ten_is_false()
        {
            _gameGrid = new GameGrid();
            Assert.That(_gameGrid.battleshipRow, GreaterThan(0));
            Assert.That(_gameGrid.battleshipRow, LessThan(11));
        }


    }
}
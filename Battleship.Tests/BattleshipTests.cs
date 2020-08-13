using System;
using BattleShip;
using NUnit.Framework;

namespace Battleship.Tests
{
    [TestFixture]
    public class BattleshipTests
    {
        private BattleShip.Battleship _battleship;

        [SetUp]
        public void Setup()
        {
            _battleship = new BattleShip.Battleship();
          
        }

        [Test]
        public void should_return_false_for_shoot_missile()
        {
            var result = _battleship.ShootMissile(_battleship.Row - 1, _battleship.Column);
            Assert.IsFalse(result);
        }

        [Test]
        public void should_return_true_for_shoot_missile()
        {
            var result = _battleship.ShootMissile(_battleship.Row, _battleship.Column);
            Assert.IsTrue(result);
        }

        [Test]
        public void should_increment_hits_for_shoot_missile()
        {
            var hits = _battleship.Hits;

            _battleship.ShootMissile(_battleship.Row, _battleship.Column);

            Assert.That(_battleship.Hits, Is.EqualTo(hits + 1));
        }

        [Test]
        public void should_return_true_for_is_sunk()
        {
            _battleship.ShootMissile(_battleship.Row, _battleship.Column);
            _battleship.ShootMissile(_battleship.Row, _battleship.Column);
            _battleship.ShootMissile(_battleship.Row, _battleship.Column);
            _battleship.ShootMissile(_battleship.Row, _battleship.Column);
            _battleship.ShootMissile(_battleship.Row, _battleship.Column);

            var result = _battleship.IsSunk();
            Assert.IsTrue(result);
        }

        [Test]
        public void should_return_false_for_is_sunk()
        {
            _battleship.ShootMissile(_battleship.Row - 1, _battleship.Column);
            _battleship.ShootMissile(_battleship.Row -1 , _battleship.Column);
            _battleship.ShootMissile(_battleship.Row - 1, _battleship.Column);
            _battleship.ShootMissile(_battleship.Row - 1, _battleship.Column);
            _battleship.ShootMissile(_battleship.Row - 1, _battleship.Column);

            var result = _battleship.IsSunk();
            Assert.IsFalse(result);
        }

    }
}
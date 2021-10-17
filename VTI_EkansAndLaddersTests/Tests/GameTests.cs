using System;
using VTI_EkansAndLadders;
using VTI_EkansAndLadders.Entities;
using VTI_EkansAndLadders.Entities.Interfaces;
using VTI_EkansAndLaddersTests.Doubles;
using Xunit;

namespace VTI_EkansAndLaddersTests.Tests
{
    public class GameTests
    {
        private readonly Cell[] _cells = new Cell[100];
        private readonly DiceDouble _dice;
        private readonly Board _board;

        public GameTests()
        {
            for (int i = 0; i < 100; i++)
            {
                _cells[i] = new Cell(i);
            }

            _board = new(_cells);
            _dice = new DiceDouble();
        }

        [Fact]
        public void Game_WhenThePlayerGetsARollToReachTheLastPositionWins()
        {
            var token = new Token(_cells[0], "Samuel");
            var _game = new Game(_dice, _board, token);
            _dice.ValueToReturn = 99;
            _game.Initialize();
            Assert.Equal(99, token.GetPosition());
        }
    }
}

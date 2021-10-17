using System;
using System.Linq;
using VTI_EkansAndLadders.Entities;
using VTI_EkansAndLaddersTests.Helpers;
using Xunit;

namespace VTI_EkansAndLaddersTests.Tests
{
    public class DiceTests
    {
        private readonly NormalCell[] _cells;

        public DiceTests()
        {
            _cells = CellHelper.GetDefaultCells();
        }

        [Fact]
        public void Dice_MoveTheTokenBasedOnDiceRoll()
        {
            //Arrange
            int Notexpected = 0;

            NormalCell[] cells = new NormalCell[100];

            for (int i = 0; i < 100; i++)
            {
                cells[i] = new NormalCell(i);
            }

            Board board = new(cells);
            Token token = new(board.Cells[0], "Samuel");
            Dice dice = new();

            //Act
            board.MoveToken(dice.Roll(), token);
            int finalPosition = token.GetPosition();

            // Assert
            Assert.NotEqual(Notexpected, finalPosition);
        }

        [Fact]
        public void Dice_TheResultOfTheRollWillBeBetweenOneAndSixInclusive()
        {
            //Arrange
            bool expected = true;

            NormalCell[] cells = new NormalCell[100];

            for (int i = 0; i < 100; i++)
            {
                cells[i] = new NormalCell(i);
            }

            Board board = new(cells);
            Token token = new(board.Cells[0], "Samuel");
            Dice dice = new();

            //Act
            bool correctResult = true;

            for (int i = 0; i < 60; i++)
            {
                if (!Enumerable.Range(1, 6).Contains(dice.Roll()))
                {
                    correctResult = false;
                    break;
                }
            }

            // Assert
            Assert.Equal(expected, correctResult);
        }
    }
}

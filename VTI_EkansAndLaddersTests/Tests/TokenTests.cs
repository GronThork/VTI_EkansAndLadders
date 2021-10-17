using System;
using VTI_EkansAndLadders.Entities;
using VTI_EkansAndLaddersTests.Helpers;
using Xunit;

namespace VTI_EkansAndLaddersTests.Tests
{
    public class TokenTests
    {
        private readonly Cell[] _cells;

        public TokenTests()
        {
            _cells = CellHelper.GetDefaultCells();
        }

        [Fact]
        public void Token_WhenTheGameStartsTheTokenIsOnSquareOne()
        {
            //Arrange
            int expected = 0;

            Cell[] cells = new Cell[100];

            for (int i = 0; i < 100; i++)
            {
                cells[i] = new Cell(i);
            }

            Board board = new(cells);
            Token token = new(board.Cells[0], "Samuel");

            //Act
            int initialPosition = token.GetPosition();

            // Assert
            Assert.Equal(expected, initialPosition);
        }
    }
}
